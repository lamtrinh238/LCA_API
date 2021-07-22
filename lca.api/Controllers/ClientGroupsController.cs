using LCA.Service.Interface;
using LCA.Service.Models.filters;
using LCA.Services.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace LCA.API.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ClientGroupsController : ControllerBase
    {
        private readonly IClientGroupReadService _clientGroupReadService;

        public ClientGroupsController(IClientGroupReadService clientGroupReadService)
        {
            this._clientGroupReadService = clientGroupReadService;
        }

        // GET api/<ClientsController>/5
        [HttpGet()]
        public IEnumerable<ClientGroupModel> Get([FromQuery] BaseFilter filter)
        {
            return _clientGroupReadService.Filter(filter);
        }
    }
}
