using LCA.Service.Models.filters;
using LCA.Services.Models;
using System.Collections.Generic;

namespace LCA.Service.Interface
{
    public interface IClientService
    {
        public ClientResultModel Filter(ClientFilter filter);
    }
}
