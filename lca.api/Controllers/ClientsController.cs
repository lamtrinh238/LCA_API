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
        private readonly IClientReadService _clientReadService;

        public ClientsController(IClientReadService clientReadService)
        {
            this._clientReadService = clientReadService;
        }

        // GET api/<ClientsController>/5
        [HttpGet("{clientID:int}")]
        public ClientGeneralModel Get(int clientID)
        {
            return _clientReadService.GetClientByID(clientID);
        }

        // GET api/<ClientsController>/5
        [HttpGet()]
        public IEnumerable<ClientModel> Get([FromQuery] BaseFilter filter)
        {
            return _clientReadService.Filter(filter);
        }
    }
}
