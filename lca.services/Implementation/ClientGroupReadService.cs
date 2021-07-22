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
    public class ClientGroupReadService : IClientGroupReadService
    {
        private readonly LcaDbContext _dbContext;
        public ClientGroupReadService(LcaDbContext dbContext)
        {
            this._dbContext = dbContext;
        }


        public IEnumerable<ClientGroupModel> Filter(BaseFilter testFilter)
        {
            var query = from gr in _dbContext.ClientGroups
                        select new ClientGroupModel()
                        {
                            Id = gr.Id,
                            GroupName = gr.GroupName,
                        };
            string sqlStr = query.ApplyFilterToQueryString(testFilter);
            List<ClientGroupModel> Countrys = _dbContext.RawSqlQuery(sqlStr).ConvertDataTable<ClientGroupModel>();
            return Countrys;
        }

    }
}
