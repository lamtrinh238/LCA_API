using LCA.Data.Context;
using LCA.Services.Interface;
using LCA.Services.Models;
using System.Collections.Generic;
using System.Linq;

namespace LCA.Services.Implementation
{
    public class EPDHeadingService : IEPDHeadingService
    {
        private readonly LcaDbContext _dbContext;

        public EPDHeadingService(LcaDbContext dbContext)
        {
            this._dbContext = dbContext;
        }
        public IEnumerable<EPDHeading> GetAllEPDHeading(int page, int pageSize)
        {
            return this._dbContext.Epdheadings.Skip((page - 1) * pageSize).Take(pageSize).Select(p => new EPDHeading(p));
        }
    }
}
