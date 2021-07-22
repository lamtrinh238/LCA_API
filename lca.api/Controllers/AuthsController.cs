using LCA.Services.Interface;
using LCA.Services.Models;
using Microsoft.AspNetCore.Mvc;

namespace LCA.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthsController : ControllerBase
    {
        private readonly IAuthsService _authService;

        public AuthsController(IAuthsService authService)
        {
            _authService = authService;
        }

        [HttpPost("authenticate")]
        public IActionResult Authenticate(AuthenticateRequestModel model)
        {
            var response = _authService.Authenticate(model);

            if (response == null)
                return BadRequest(new { message = "Username or password is incorrect" });

            return Ok(response);
        }

    }
}
