using LCA.Data.Context;
using LCA.Service.Models.filters;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Linq;
using System.Reflection;

namespace LCA.Service.Helpers
{
    public static class FilterHelper
    {
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
						//if (column.DataType == typeof(string))
						//{
						//	pro.SetValue(obj, dr.IsNull(column.ColumnName) ? "" : dr[column.ColumnName], null);
						//}
      //                  else 
						//{
							
						//}
						var colVal = dr.IsNull(column.ColumnName) ? null : dr[column.ColumnName];
						pro.SetValue(obj, colVal, null);
					}
					else
						continue;
				}
			}
			return obj;
		}
		public static string ApplyFilterToQueryString<T>(this IQueryable<T> source, BaseFilter filter)
		{
			filter = filter.CorrectFilter(source);
			Type typeOfModel = source.GetType().GenericTypeArguments[0];
			string tableNameAlias = typeOfModel.Name;
			filter = filter.CorrectFilter(source);
			string sqlSelect = $"SELECT [{tableNameAlias}].* FROM ( { source.ToQueryString() } ) AS [{tableNameAlias}]";
			string sqlWhere = filter.GeneratedWhere(tableNameAlias);
			string sqlSort = filter.GenerateOrderBy(tableNameAlias);
			string sqlPaging = $"OFFSET ({filter.SkipSize}) ROWS FETCH NEXT ({filter.PageSize}) ROWS ONLY";

			return sqlSelect + Environment.NewLine + sqlWhere + Environment.NewLine + sqlSort + Environment.NewLine + sqlPaging;
		}

		private static string GeneratedWhere(this BaseFilter filter, string tableNameAlias) 
		{
			string whereStr = "WHERE 1 = 1";
			foreach (SearchItem item in filter.SearchItems)
			{
				string strOperator = string.Empty;
				switch (item.Operator)
				{
					case Operator.Equal:
						whereStr += $" AND [{tableNameAlias}].[{item.FieldName}] == '{item.Value}'";
						break;
					case Operator.NotEqual:
						whereStr += $" AND [{tableNameAlias}].[{item.FieldName}] != '{item.Value}'";
						break;
					case Operator.GreaterThan:
						whereStr += $" AND [{tableNameAlias}].[{item.FieldName}] > {item.Value}";
						break;
					case Operator.LessThan:
						whereStr += $" AND [{tableNameAlias}].[{item.FieldName}] < {item.Value}";
						break;
					case Operator.GreaterThanOrEqual:
						whereStr += $" AND [{tableNameAlias}].[{item.FieldName}] >= {item.Value}";
						break;
					case Operator.LessThanOrEqual:
						whereStr += $" AND [{tableNameAlias}].[{item.FieldName}] <= {item.Value}";
						break;
					case Operator.Between:
						break;
					case Operator.Like:
						whereStr += $" AND [{tableNameAlias}].[{item.FieldName}] LIKE '%{item.Value}%'";
						break;
					case Operator.In:
						break;
					default:
						break;
				}

			}
			return whereStr;
		}

		private static string GenerateOrderBy(this BaseFilter filter, string tableNameAlias)
		{
			string sortName = filter.SortItems.FieldName;
			string sortOrder = filter.SortItems.SortType.ToString();
			return $"ORDER BY [{tableNameAlias}].[{sortName}] {sortOrder}";
		}

		private static BaseFilter CorrectFilter(this BaseFilter filter, IQueryable source)
		{
			Type typeOfModel = source.GetType().GenericTypeArguments[0];
			PropertyInfo[] props = typeOfModel.GetProperties();

			List<SearchItem> validSearchItems = new List<SearchItem>();
			foreach (SearchItem search in filter.SearchItems)
			{
                if (props.Where(c => string.Equals(c.Name, search.FieldName, StringComparison.OrdinalIgnoreCase)).Any())
                {
					validSearchItems.Add(search);
				}
			}

			// 
			filter.SearchItems = validSearchItems;
			if (filter.SortItems != null && !props.Where(c => string.Equals(c.Name, filter.SortItems.FieldName, StringComparison.OrdinalIgnoreCase)).Any())
			{
				filter.SortItems = null;
			}

			return filter;
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
							string auth = colAttr.Name;

							iTableInfo.ColumnName.Add(propName, auth);
						}
					}
				}
				result.Add(iTableInfo);
			}
			return result;
		}
	}
	public class TableInfo 
	{
		public string TableName { get; set; }

		public Dictionary<string, string> ColumnName { get; set; }
	}
}
