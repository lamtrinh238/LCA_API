﻿using LCA.Services.Interface;
using LCA.Services.Models;
using Microsoft.AspNetCore.Mvc;

namespace LCA.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthsController : ControllerBase
    {
        private IAuthsService _userService;

        public AuthsController(IAuthsService userService)
        {
            _userService = userService;
        }

        [HttpPost("authenticate")]
        public IActionResult Authenticate(AuthenticateRequestModel model)
        {
            var response = _userService.Authenticate(model);

            if (response == null)
                return BadRequest(new { message = "Username or password is incorrect" });

            return Ok(response);
        }

        [Authorize]
        [HttpGet]
        public IActionResult GetAll()
        {
            var users = _userService.GetAll();
            return Ok(users);
        }
    }
}