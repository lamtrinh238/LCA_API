using LCA.Service.Interface;
using LCA.Service.Models.filters;
using LCA.Services.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LCA.API.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserReadService _userReadService;
        private readonly IUserWriteService _userWriteService;

        public UsersController(IUserReadService userReadService, IUserWriteService userWriteService)
        {
            this._userReadService = userReadService;
            this._userWriteService = userWriteService;
        }

        // GET api/<UsersController>/5
        [HttpGet("{userID:int}")]
        public UserCompanyModel Get(int userID)
        {
            return this._userReadService.GetUserWithCompaniesByID(userID);
        }
        // GET api/<UsersController>/5
        [HttpGet()]
        public IEnumerable<UserModel> Get([FromQuery] UserFilter filter)
        {
            return this._userReadService.Filter(filter);
        }

        // POST api/<UsersController>
        [HttpPost()]
        public IActionResult Get([FromBody] UserModel user)
        {
            var currentUser = this.HttpContext.Items["User"] as UserModel;
            user.UsrCreatedby = currentUser.UsrId;
            var userID = this._userWriteService.CreateUser(user);
            return Ok(new
            {
                ID = userID
            });
        }
    }
}
