using LCA.Service.Models.filters;
using LCA.Services.Models;
using System.Collections.Generic;

namespace LCA.Service.Interface
{
    public interface IClientReadService
    {
        public ClientGeneralModel GetClientByID(int clientID);
        public IEnumerable<ClientModel> Filter(ClientFilter filter);
        public IEnumerable<ClientModel> Filter(BaseFilter testFilter);
        public IEnumerable<ClientModel> FilterCompany(int clientID, BaseFilter filter);
        public IEnumerable<EPDDefaultA2Model> FilterEPDDefaultA2(int clientID);
        public IEnumerable<EPDDefaultA3Model> FilterEPDDefaultA3(int clientID);
    }
}
