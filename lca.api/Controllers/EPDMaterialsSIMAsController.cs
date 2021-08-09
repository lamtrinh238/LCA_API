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
    public class EPDMaterialsSIMAsController : ControllerBase
    {
        private readonly IEPDMaterialsSIMAReadService _ePDMaterialsSIMAReadService;

        public EPDMaterialsSIMAsController(IEPDMaterialsSIMAReadService ePDMaterialsSIMAReadService)
        {
            this._ePDMaterialsSIMAReadService = ePDMaterialsSIMAReadService;
        }

        // GET api/<EPDMaterialsSIMAsController>/5
        [HttpGet()]
        public IEnumerable<EPDMaterialsSIMAModel> Get(int type)
        {
            return _ePDMaterialsSIMAReadService.FilterForClient(type);
        }
    }
}
