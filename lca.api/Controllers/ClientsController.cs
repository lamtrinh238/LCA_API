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
    public class ClientsController : ControllerBase
    {
        private readonly IClientService _clientService;

        public ClientsController(IClientService clientService)
        {
            this._clientService = clientService;
        }

        // GET api/<ClientsController>/5
        [HttpGet()]
        public IEnumerable<ClientModel> Get([FromQuery] BaseFilter filter)
        {
            return _clientService.Filter(filter);
        }
    }
}
