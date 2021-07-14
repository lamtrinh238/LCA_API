using LCA.Data.Context;
using LCA.Service.Models.filters;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection;

namespace LCA.Service.Helpers
{
    public static class FilterHelper
    {
		public static string ApplyFilterToQueryString<T>(this IQueryable<T> source, BaseFilter filter)
		{
			filter = filter.CorrectFilter(source);
			string sqlString = source.ToQueryString();
			//string sqlString = "SELECT [c].[COM_ID], [c].[COM_ADD], [c].[COM_BannerLogo], [c].[COM_CITY], [c].[COM_COMPANYNAME], [c].[COM_COMPANYVAT], [c].[COM_Country], [c].[COM_CREATEDBY], [c].[COM_CREATEDTTM], [c].[COM_Dir], [c].[COM_EMAIL], [c].[COM_EPDInfo1], [c].[COM_EPDInfo2], [c].[COM_EPDInfo3], [c].[COM_EPDInfo4], [c].[COM_EPDPicture1], [c].[COM_EPDPicture2], [c].[COM_GUID], [c].[COM_Logo], [c].[COM_MainContact], [c].[COM_ManagmentSys], [c].[COM_Modul_Sharing], [c].[COM_Modul_SubFase], [c].[COM_PageText], [c].[COM_PaidTO], [c].[COM_PHONE1], [c].[COM_PHONE2], [c].[COM_ProgramOperator], [c].[COM_PROID], [c].[COM_Startup], [c].[COM_STATUS], [c].[COM_System], [c].[COM_Token], [c].[COM_TYPE], [c].[COM_WEB], [c].[COM_ZIP], [c0].[int], [c0].[Alpha2Code], [c0].[Alpha3Code], [c0].[CountryName], [c0].[Language], [c0].[NumericCode]\r\nFROM [COMPANY] AS [c]\r\nINNER JOIN [COUNTRY] AS [c0] ON [c].[COM_Country] = [c0].[int]";


			int slPosition = sqlString.IndexOf("SELECT", StringComparison.OrdinalIgnoreCase);
			int fromPosition = sqlString.IndexOf("FROM", StringComparison.OrdinalIgnoreCase);
			List<int> joinPosition = new List<int>();
			int count = 0, minIndex = sqlString.IndexOf("JOIN", 0);
			while (minIndex != -1)
			{
				minIndex = sqlString.IndexOf("JOIN", minIndex + "JOIN".Length);
				joinPosition.Add(minIndex);
				count++;
			}
			string selectStr = sqlString.Substring(0, slPosition);
			string fromStr = sqlString.Substring(fromPosition, sqlString.IndexOf("JOIN", 0));


			List<TableInfo> tablesInfo = GetTablesInfo(typeof(LcaDbContext).Assembly, "LCA.Data.Domain");

			return string.Empty;
			//BaseFilter filterValid = ValidateFilter(source, filter);
			//return (IQueryable<T>)ApplyFilter((IQueryable)source, filter);
		}

		public static BaseFilter CorrectFilter(this BaseFilter filter, IQueryable source)
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
