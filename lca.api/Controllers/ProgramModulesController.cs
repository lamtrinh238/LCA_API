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
    public class ProgramModulesController : ControllerBase
    {
        private readonly IProgramModuleReadService _programModuleReadService;

        public ProgramModulesController(IProgramModuleReadService programModuleReadService)
        {
            this._programModuleReadService = programModuleReadService;
        }

        // GET api/<ClientsController>/5
        [HttpGet()]
        public IEnumerable<ProgramModuleModel> Get([FromQuery] BaseFilter filter)
        {
            return _programModuleReadService.filter(filter);
        }
    }
}
