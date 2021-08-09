using LCA.Service.Models.filters;
using LCA.Services.Models;
using System.Collections.Generic;

namespace LCA.Service.Interface
{
    public interface IEPDMaterialsSIMAReadService
    {
        public IEnumerable<EPDMaterialsSIMAModel> FilterForClient(int type);
    }
}
