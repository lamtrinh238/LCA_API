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
        public IEnumerable<UserModel> FilterUser(int clientID);
    }
}
