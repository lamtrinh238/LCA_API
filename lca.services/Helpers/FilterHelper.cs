using LCA.Data.Context;
using LCA.Service.Models.filters;
using LCA.Services.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace LCA.Service.Helpers
{
    public static class FilterHelper
    {
		public static IQueryable<T> ApplyFilter<T>(this IQueryable<T> source, BaseFilter filter, LcaDbContext lcaDbContext)
		{
            var sqlString = source.ToQueryString();

			var result = lcaDbContext.RawSqlQuery(sqlString,
				x => new UserModel { Name = (string)x[0].ToString(), Count = (string)x[1] });

			if (source.Count() == 0)
			{
				return source;
			}
			return source;
			//BaseFilter filterValid = ValidateFilter(source, filter);
			//return (IQueryable<T>)ApplyFilter((IQueryable)source, filter);
		}

	}
}
