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
    public class EPDPCRReadService : IEPDPCRReadService
    {
        private readonly LcaDbContext _dbContext;
        public EPDPCRReadService(LcaDbContext dbContext)
        {
            this._dbContext = dbContext;
        }


        public IEnumerable<EPDPCRModel> Filter(BaseFilter testFilter)
        {
            var query = from epdpcr in _dbContext.Epdpcrs
                        select new EPDPCRModel()
                        {
                            Id = epdpcr.Id,
                            Pcrname = epdpcr.Pcrname,
                        };
            string sqlStr = query.ApplyFilterToQueryString(testFilter);
            List<EPDPCRModel> Countrys = _dbContext.RawSqlQuery(sqlStr).ConvertDataTable<EPDPCRModel>();
            return Countrys;
        }

    }
}
