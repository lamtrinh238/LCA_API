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
    public class ProgramModuleReadService : IProgramModuleReadService
    {
        private readonly LcaDbContext _dbContext;
        public ProgramModuleReadService(LcaDbContext dbContext)
        {
            this._dbContext = dbContext;
        }

        public IEnumerable<ProgramModuleModel> filter(BaseFilter filter)
        {
            var query = from pm in _dbContext.ProgramModules
                        select new ProgramModuleModel()
                        {
                            Id = pm.Id,
                            Name = pm.Name,
                        };
            string sqlStr = query.ApplyFilterToQueryString(filter);
            List<ProgramModuleModel> res = _dbContext.RawSqlQuery(sqlStr).ConvertDataTable<ProgramModuleModel>();
            return res;
        }
    }
}
