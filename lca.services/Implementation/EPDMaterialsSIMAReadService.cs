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
    public class EPDMaterialsSIMAReadService : IEPDMaterialsSIMAReadService
    {
        private readonly LcaDbContext _dbContext;
        public EPDMaterialsSIMAReadService(LcaDbContext dbContext)
        {
            this._dbContext = dbContext;
        }

        public IEnumerable<EPDMaterialsSIMAModel> FilterForClient(int type)
        {
            var query = from material in _dbContext.EpdmaterialsSimas
                        where material.CustomerId == 0
                        where type == 2 ? material.A2 == 1 : (type == 3 ? material.A3 == 1 : material.A4 == 1)
                        select new EPDMaterialsSIMAModel()
                        {
                            Id = material.Id,
                            EpdmaterialId = material.EpdmaterialId,
                            EpdmaterialName = material.EpdmaterialName,
                        };
            List<EPDMaterialsSIMAModel> materials = query.Select(m => m).ToList();
            return materials;
        }
    }
}
