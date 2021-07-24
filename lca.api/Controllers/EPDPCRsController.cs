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
    public class EPDPCRsController : ControllerBase
    {
        private readonly IEPDPCRReadService _ePDPCRReadService;

        public EPDPCRsController(IEPDPCRReadService ePDPCRReadService)
        {
            this._ePDPCRReadService = ePDPCRReadService;
        }

        // GET api/<ClientsController>/5
        [HttpGet()]
        public IEnumerable<EPDPCRModel> Get([FromQuery] BaseFilter filter)
        {
            return _ePDPCRReadService.Filter(filter);
        }
    }
}
