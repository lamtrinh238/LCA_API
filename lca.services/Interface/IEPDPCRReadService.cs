using LCA.Service.Models.filters;
using LCA.Services.Models;
using System.Collections.Generic;

namespace LCA.Service.Interface
{
    public interface IEPDPCRReadService
    {
        public IEnumerable<EPDPCRModel> Filter(BaseFilter testFilter);
    }
}
