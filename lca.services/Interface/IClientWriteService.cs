using LCA.Service.Models.filters;
using LCA.Services.Models;
using System.Collections.Generic;

namespace LCA.Service.Interface
{
    public interface IClientWriteService
    {
        long CreateClient(ClientModel client);
        long UpdateClient(int clientID, ClientUpdateModel client);
    }
}
