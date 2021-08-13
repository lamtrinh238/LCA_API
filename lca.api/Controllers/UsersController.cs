using LCA.Service.BusinessExceptions;
using LCA.Service.Interface;
using LCA.Service.Models;
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
            _userReadService = userReadService;
            _userWriteService = userWriteService;
        }

        // GET api/<UsersController>/5
        [HttpGet("{userID:int}")]
        public UserCompanyModel Get(int userID)
        {
            return _userReadService.GetUserWithCompaniesByID(userID);
        }
        // GET api/<UsersController>/5
        [HttpGet()]
        public IEnumerable<UserModel> Get([FromQuery] BaseFilter filter)
        {
            return _userReadService.Filter(filter);
        }

        // POST api/<UsersController>
        [HttpPost()]
        public IActionResult Create([FromBody] UserModel user)
        {
            UserModel currentUser = HttpContext.Items["User"] as UserModel;
            user.UsrCreatedby = currentUser.UsrId;
            var userID = _userWriteService.CreateUser(user);
            return Ok(new
            {
                ID = userID
            });
        }

        // PUT api/<UsersController>/5
        [HttpPut("{userID:long}")]
        public IActionResult Update(long userID, [FromBody] UserModel user)
        {
            _userWriteService.UpdateUser(userID, user);
            return Ok(new
            {
                ID = userID
            });
        }

        // DELETE api/<UsersController>/5
        [HttpDelete("{userID:long}")]
        public IActionResult Delete(long userID)
        {
            _userWriteService.DeleteUser(userID);
            return Ok(new
            {
                ID = userID
            });
        }

        // PUT api/<UsersController>/5/change_password
        [HttpPut("{userID:long}/changePassword")]
        public IActionResult ChangePassword(long userID, [FromBody] PasswordChangeModel model)
        {
            UserModel currentUser = HttpContext.Items["User"] as UserModel;

            if (currentUser.UsrId != userID)
            {
                throw new CannotChangeOtherUserPasswordException();
            }

            _userWriteService.ChangePassword(userID, model);


            return Ok(new
            {
                ID = userID
            });
        }

        // GET api/<ClientsController>/5/users
        [HttpGet("clients/{clientID:int}")]
        public IEnumerable<UserModel> GetUsers(int clientID)
        {
            return _userReadService.FilterByCompany(clientID);
        }
    }
}
