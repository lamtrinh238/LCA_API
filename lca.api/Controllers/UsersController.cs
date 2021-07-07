using LCA.Service.Interface;
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
        private readonly IUserService _userService;

        public UsersController(IUserService userService)
        {
            this._userService = userService;
        }

        // GET api/<UsersController>/5
        [HttpGet("{userID:int}")]
        public UserModel Get(int userID)
        {
            return this._userService.GetUserByID(userID);
        }
    }
}
