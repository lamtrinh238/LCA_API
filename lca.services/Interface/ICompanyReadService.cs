using System.Collections.Generic;
using LCA.Service.Models.filters;
using LCA.Services.Models;

namespace LCA.Service.Interface
{
    public interface ICompanyReadService
    {
        public IEnumerable<CompanyModel> Filter(BaseFilter testFilter);
    }
}