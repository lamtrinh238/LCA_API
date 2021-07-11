using LCA.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCA.Service.Implementation
{
    public class DbContextService
    {
        protected readonly LcaDbContext _dbContext;
        public DbContextService(LcaDbContext dbContext)
        {
            this._dbContext = dbContext;
        }
    }
}
