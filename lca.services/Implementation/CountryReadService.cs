using LCA.Data.Context;
using LCA.Service.Helpers;
using LCA.Service.Interface;
using LCA.Service.Models.filters;
using LCA.Services.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace LCA.Services.Implementation
{
    public class CountryReadService : ICountryReadService
    {
        private readonly LcaDbContext _dbContext;
        public CountryReadService(LcaDbContext dbContext)
        {
            this._dbContext = dbContext;
        }


        public IEnumerable<CountryModel> Filter(BaseFilter testFilter)
        {
            var query = from country in _dbContext.Countries
                        select new CountryModel()
                        {
                            Int = country.Int,
                            CountryName = country.CountryName,
                            Alpha2Code = country.Alpha2Code,
                            Alpha3Code = country.Alpha3Code,
                            NumericCode = country.NumericCode,
                            Language = country.Language,
                        };
            string sqlStr = query.ApplyFilterToQueryString(testFilter);
            List<CountryModel> Countrys = _dbContext.RawSqlQuery(sqlStr).ConvertDataTable<CountryModel>();
            return Countrys;
        }

    }
}
