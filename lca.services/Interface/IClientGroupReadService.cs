using LCA.Service.Models.filters;
using LCA.Services.Models;
using System.Collections.Generic;

namespace LCA.Service.Interface
{
    public interface IClientGroupReadService
    {
        public IEnumerable<ClientGroupModel> Filter(BaseFilter testFilter);
    }
}
