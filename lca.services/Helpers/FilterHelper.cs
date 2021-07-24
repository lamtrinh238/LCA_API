using LCA.Data.Context;
using LCA.Service.Models.filters;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Web;

namespace LCA.Service.Helpers
{
    public static class FilterHelper
	{
		public static string ApplyFilterToQueryString<T>(this IQueryable<T> source, BaseFilter filter)
		{
			QueryInfo queryInfo = ParsingQuery(source);
			filter = filter.CorrectFilter(queryInfo);
			string sqlWhere = filter.GeneratedWhere(queryInfo);
			string sqlSort = filter.GenerateOrderBy(queryInfo);
			string sqlPaging = $"OFFSET ({filter.SkipSize}) ROWS FETCH NEXT ({filter.PageSize}) ROWS ONLY";

			return queryInfo.SqlDeclare + Environment.NewLine +
				queryInfo.SqlSelect + Environment.NewLine +
				queryInfo.SqlFrom + Environment.NewLine +
				sqlWhere + Environment.NewLine +
				sqlSort + Environment.NewLine +
				sqlPaging;
		}

		public static List<FilterItem> GetFilterItems(this BaseFilter filter) 
		{
			List<FilterItem> result = new List<FilterItem>();
			if (!string.IsNullOrEmpty(filter.FilterText))
			{
				filter.FilterText = HttpUtility.UrlDecode(filter.FilterText);
				string[] filterSplit = filter.FilterText.Split("&");
				foreach (var item in filterSplit)
				{
					if (!Enum.TryParse(GetNameInBracket(item), true, out Operator oprEnum))
						continue;
					int index1 = item.IndexOf('[');
					int index2 = item.IndexOf(']');
					string filterKey = item.Substring(0, index1);
					string filterVal = item.Substring(index2 + 1);
					result.Add(new FilterItem() { FieldName = filterKey, Operator = oprEnum, Value = filterVal });
				}
			}
			return result;
		}

		private static QueryInfo ParsingQuery<T>(IQueryable<T> source)
		{
			QueryInfo queryInfo = new QueryInfo();
			List<TableInfo> allTablesInfo = GetTablesInfo(typeof(LcaDbContext).Assembly, "LCA.Data.Domain");
			const string declare = "DECLARE";
			const string select = "SELECT";
			const string from = "FROM";
			const string where = "WHERE";
			string sourceQuery = source.ToQueryString();

			int index1 = sourceQuery.IndexOf(declare, StringComparison.OrdinalIgnoreCase);
			index1 = index1 >= 0 ? index1 : 0;
			int index2 = sourceQuery.IndexOf(select, StringComparison.OrdinalIgnoreCase);
			int index3 = sourceQuery.IndexOf(from, StringComparison.OrdinalIgnoreCase);
			int index4 = sourceQuery.IndexOf(where, StringComparison.OrdinalIgnoreCase);
			index4 = index4 >= 0 ? index4 : sourceQuery.Length;

			string sqlDeclare = sourceQuery.Substring(index1, index2).Trim();
			string sqlSelect = sourceQuery.Substring(index2, index3 - index2).Trim();
			string sqlFrom = sourceQuery.Substring(index3, index4 - index3).Trim();
			string sqlWhere = sourceQuery.Substring(index4).Trim();


			// get select fields
			string[] selectSplit = sqlSelect.Replace(select, "", StringComparison.OrdinalIgnoreCase).Trim().Split(",");
			for (int i = 0; i < selectSplit.Length; i++)
			{
				string[] field = selectSplit[i].Trim().Split("AS");
				string fieldName = field[0].Trim();
				string fieldAlias = field.Length == 1 ? fieldName : field[1].Trim();
				queryInfo.SelectFields.Add(fieldAlias, fieldName);
			}

			// get tables from
			string[] fromSplit = sqlFrom.Replace(from, "", StringComparison.OrdinalIgnoreCase).Trim().Split(" ");
			for (int i = 0; i < fromSplit.Length; i++)
			{
				if (fromSplit[i].Equals("AS", StringComparison.OrdinalIgnoreCase))
				{
					string tableName = GetNameInBracket(fromSplit[i - 1]);
					string tableAlias = GetNameInBracket(fromSplit[i + 1]);
					TableInfo tableInfo = allTablesInfo.Where(c => GetNameInBracket(c.TableName).Equals(tableName)).FirstOrDefault();
					queryInfo.TablesJoin.Add($"[{tableAlias}]", tableInfo);
				}
			}

			queryInfo.SqlDeclare = sqlDeclare;
			queryInfo.SqlSelect = sqlSelect;
			queryInfo.SqlFrom = sqlFrom;
			queryInfo.SqlWhere = sqlWhere;
			return queryInfo;
		}

		private static BaseFilter CorrectFilter(this BaseFilter filter, QueryInfo queryInfo)
		{
			// parsing global search
			filter.GlobalSearch = HttpUtility.UrlDecode(filter.GlobalSearch);
			if (!string.IsNullOrEmpty(filter.GlobalSearch))
			{
				if (Enum.TryParse(GetNameInBracket(filter.GlobalSearch), true, out Operator oprEnum))
				{
					int index1 = filter.GlobalSearch.IndexOf('[');
					int index2 = filter.GlobalSearch.IndexOf(']');
					List<string> filterKeys = filter.GlobalSearch.Substring(0, index1).Split(',').ToList();
					string filterVal = filter.GlobalSearch.Substring(index2 + 1);
					var filterKeysValid = filterKeys
						.Where(c => filterKeys.Contains(c, StringComparer.CurrentCultureIgnoreCase))
						.Select(s => new FilterItem() { FieldName = s, Operator = Operator.Like, Value = filterVal });
					filter.FilterItems.AddRange(filterKeysValid);
				}
			}

			// parsing filter
			if (string.IsNullOrEmpty(filter.GlobalSearch))
			{
				var filtervalid = filter.GetFilterItems()
					.Where(c1 => queryInfo.SelectFields.Where(c => string.Equals(GetNameInBracket(c.Key), GetNameInBracket(c1.FieldName), StringComparison.OrdinalIgnoreCase)).Any()).ToList();
				filter.FilterItems = filtervalid ?? new List<FilterItem>();
			}
			if (!filter.FilterItems.Any())
			{
				filter.GlobalSearch = string.Empty;
				filter.FilterText = string.Empty;
			}

			// set order by default is first column. because order is required for paging
			filter.SortItems = new SortItem() { FieldName = GetNameInBracket(queryInfo.SelectFields.FirstOrDefault().Key), SortType = SortType.ASC };

			// parsing sort
			if (!string.IsNullOrEmpty(filter.SortText))
			{
				string[] sortSplit = filter.SortText.Split(".");
				if (sortSplit.Length == 2
					&& Enum.TryParse(sortSplit[1], true, out SortType sortEnum)
					&& queryInfo.SelectFields.Where(c => string.Equals(GetNameInBracket(c.Key), GetNameInBracket(sortSplit[0]), StringComparison.OrdinalIgnoreCase)).Any())
				{
					filter.SortItems = new SortItem() { FieldName = sortSplit[0], SortType = sortEnum };
				}
			}

			return filter;
		}

		public static List<T> ConvertDataTable<T>(this DataTable dt)
		{
			List<T> data = new List<T>();
			foreach (DataRow row in dt.Rows)
			{
				T item = GetItem<T>(row);
				data.Add(item);
			}
			return data;
		}
		private static T GetItem<T>(DataRow dr)
		{
			Type temp = typeof(T);
			T obj = Activator.CreateInstance<T>();

			foreach (DataColumn column in dr.Table.Columns)
			{
				foreach (PropertyInfo pro in temp.GetProperties())
				{
					if (pro.Name == column.ColumnName)
                    {
						var colVal = dr.IsNull(column.ColumnName) ? null : dr[column.ColumnName];
						pro.SetValue(obj, colVal, null);
					}
				}
			}
			return obj;
		}

		private static string GeneratedWhere(this BaseFilter filter, QueryInfo queryInfo)
		{
			if (filter.FilterItems == null || !filter.FilterItems.Any())
			{
				return string.Empty;
			}

			string whereStr = string.IsNullOrEmpty(queryInfo.SqlWhere) ? "WHERE 1=1 " : queryInfo.SqlWhere;

			List<string> causeWhere = new List<string>();
			foreach (FilterItem item in filter.FilterItems)
			{
				var fieleInfo = queryInfo.SelectFields
					.FirstOrDefault(c => string.Equals(GetNameInBracket(c.Key), GetNameInBracket(item.FieldName), StringComparison.OrdinalIgnoreCase));
				switch (item.Operator)
				{
					case Operator.Equal:
						causeWhere.Add($"{fieleInfo.Value} = '{item.Value}'");
						break;
					case Operator.NotEqual:
						causeWhere.Add($"{fieleInfo.Value} != '{item.Value}'");
						break;
					case Operator.GreaterThan:
						causeWhere.Add($"{fieleInfo.Value} > {item.Value}");
						break;
					case Operator.LessThan:
						causeWhere.Add($"{fieleInfo.Value} < {item.Value}");
						break;
					case Operator.GreaterThanOrEqual:
						causeWhere.Add($"{fieleInfo.Value} >= {item.Value}");
						break;
					case Operator.LessThanOrEqual:
						causeWhere.Add($"{fieleInfo.Value} <= {item.Value}");
						break;
					case Operator.Between:
						break;
					case Operator.Like:
						causeWhere.Add($"{fieleInfo.Value} LIKE '%{item.Value}%'");
						break;
					case Operator.In:
						break;
					default:
						causeWhere.Add($"{fieleInfo.Value} LIKE '%{item.Value}%'");
						break;
				}
			}

			string casuseWhereStr = string.Empty;
			if (string.IsNullOrEmpty(filter.GlobalSearch))
			{
				casuseWhereStr = String.Join(" AND ", causeWhere.ToArray());
			}
			else {
				casuseWhereStr = String.Join(" OR ", causeWhere.ToArray());
			}
			return $"{whereStr} AND ({casuseWhereStr})";
		}

		private static string GenerateOrderBy(this BaseFilter filter, QueryInfo queryInfo)
		{
			if (filter.SortItems == null || string.IsNullOrEmpty(filter.SortItems.FieldName))
			{
				throw new Exception("query required order to paging");
			}
			string sortName = filter.SortItems.FieldName;
			string sortOrder = filter.SortItems.SortType.ToString();
			var fieleInfo = queryInfo.SelectFields
					.FirstOrDefault(c => string.Equals(GetNameInBracket(c.Key), GetNameInBracket(sortName), StringComparison.OrdinalIgnoreCase));
			return $"ORDER BY {fieleInfo.Value} {sortOrder}";
		}


		private static List<TableInfo> GetTablesInfo(Assembly assembly, string nameSpace)
		{
			List<TableInfo> result = new List<TableInfo>();
			  var tablesType = assembly.GetTypes()
					  .Where(t => String.Equals(t.Namespace, nameSpace, StringComparison.Ordinal))
					  .ToArray();

            foreach (var type in tablesType)
            {
				TableAttribute tableAttribute = (TableAttribute)Attribute.GetCustomAttribute(type, typeof(TableAttribute));
				if (tableAttribute == null)
					continue;

				TableInfo iTableInfo = new TableInfo() { TableName = tableAttribute.Name };
				iTableInfo.ColumnName = new Dictionary<string, string>();
				PropertyInfo[] props = type.GetProperties();
				foreach (PropertyInfo prop in props)
				{
					object[] attrs = prop.GetCustomAttributes(true);
					foreach (object attr in attrs)
					{
						ColumnAttribute colAttr = attr as ColumnAttribute;
						if (colAttr != null)
						{
							string propName = prop.Name;
							string colName = colAttr.Name;

							iTableInfo.ColumnName.Add(propName, colName);
						}
					}
				}
				result.Add(iTableInfo);
			}
			return result;
		}

		private static string GetNameInBracket(string str) 
		{
			int index1 = str.IndexOf('[');
			int index2 = str.IndexOf(']');
			if (index1 < 0 
				|| index2 < 0 
				|| (index1+2) > index2)
				return str;

			return str.Substring(index1 + 1, index2 - index1 - 1);
		}
	}

	public class TableInfo 
	{
		public string TableName { get; set; }

		// property name, column name
		public Dictionary<string, string> ColumnName { get; set; }
	}

	public class QueryInfo
	{
        public QueryInfo() 
		{
			TablesJoin = new Dictionary<string, TableInfo>();
			SelectFields = new Dictionary<string, string>();
		}

		/// <summary>
		/// table name alias, TableInfo
		/// </summary>
		public Dictionary<string, TableInfo> TablesJoin { get; set; }

		/// <summary>
		/// name alias, source
		/// </summary>
		public Dictionary<string, string> SelectFields { get; set; }
        public string SqlDeclare { get; set; }
        public string SqlSelect { get; set; }
        public string SqlWhere { get; set; }
		public string SqlFrom { get; set; }
	}
}
