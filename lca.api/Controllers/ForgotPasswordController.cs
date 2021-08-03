using LCA.Service.BusinessExceptions;
using LCA.Service.Interface;
using LCA.Service.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LCA.API.Controllers
{
    [Route("api")]
    [ApiController]
    public class ForgotPasswordController : ControllerBase
    {
        private readonly IForgotPasswordService _forgotPasswordService;
        public ForgotPasswordController(IForgotPasswordService forgotPasswordService)
        {
            _forgotPasswordService = forgotPasswordService;
        }

        // POST api/forgotPassword
        [Route("forgotPassword")]
        [HttpPost()]
        public IActionResult GeneratePasswordReset([FromBody] ForgotPasswordModel model)
        {

            _forgotPasswordService.CreateForgotPasswordRequest(model);

            return Ok(new
            {
                Message = "We send an email to you."
            });
        }

        // POST api/resetPassword
        [HttpPost("resetPassword")]
        public IActionResult Reset([FromBody] ResetPasswordModel model)
        {

            _forgotPasswordService.ResetPassword(model);

            return Ok(new
            {
                Message = "Your password has been reset successfully."
            });
        }

    }
}
