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
    [Route("api/[controller]")]
    [ApiController]
    public class ForgotPasswordController : ControllerBase
    {
        private readonly IForgotPasswordService _forgotPasswordService;
        public ForgotPasswordController(IForgotPasswordService forgotPasswordService)
        {
            _forgotPasswordService = forgotPasswordService;
        }

        // POST api/<UsersController>
        [HttpPost()]
        public IActionResult GeneratePasswordReset([FromBody] ForgotPasswordModel model)
        {
            try
            {
                _forgotPasswordService.CreateForgotPasswordRequest(model);
            }
            catch (UserNotFoundException ex)
            {
                return BadRequest(ex.ToSerializableObject());
            } catch (EmailCannotBeSentException ex)
            {
                return BadRequest(ex.ToSerializableObject());
            }


            return Ok(new
            {
                Message = "We send an email to you."
            });
        }
    }
}
