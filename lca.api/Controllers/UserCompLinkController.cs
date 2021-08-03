using System.Collections.Generic;
using LCA.Service.Interface;
using LCA.Service.Models.filters;
using LCA.Services.Models;
using Microsoft.AspNetCore.Mvc;

namespace LCA.API.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class UserCompLinkController : ControllerBase
    {
        readonly IUserWriteService _userWriteService;
        readonly ICompanyReadService _companyReadService;

        public UserCompLinkController(IUserWriteService userWriteService, ICompanyReadService companyReadService)
        {
            this._userWriteService = userWriteService;
            this._companyReadService = companyReadService;

        }

        [HttpGet("Company")]
        public IEnumerable<CompanyModel> Get([FromQuery] BaseFilter filter)
        {
            return  _companyReadService.Filter(filter);
        }

        // GET api/<ClientsController>/5/users
        [HttpPost("usercompLink")]
        public IActionResult CreateUserCompLink([FromBody] UsrCompLinkModel usrlink)
        {
            var usercompLink = _userWriteService.CreateUserCompLink(usrlink);
            return Ok(new
            {
                ID = usercompLink
            });
        }

        [HttpDelete("{companyid:int},{usrid:int}")]
        public IActionResult Delete(int companyid, int usrid)
        {
            _userWriteService.DeleteUserCompLink(companyid, usrid);
            return Ok(new
                {
                    ID = companyid
                }
            );
        }
    }
}
