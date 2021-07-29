using LCA.Service.BusinessExceptions;
using LCA.Service.Interface;
using LCA.Service.Models;
using LCA.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCA.Service.Implementation
{
    public class ForgotPasswordService : IForgotPasswordService
    {
        private readonly IUserReadService _userReadService;
        private readonly IEmailService _emailService;
        public ForgotPasswordService(IUserReadService userReadService, IEmailService emailService)
        {
            _userReadService = userReadService;
            _emailService = emailService;
        }
        public void CreateForgotPasswordRequest(ForgotPasswordModel request)
        {
            UserModel user = _userReadService.GetUserByEmail(request.UserEmail);

            if(user == null)
            {
                throw new UserNotFoundException();
            }

            // TODO;
            string token = "";
            _emailService.SendEmail(new SendEmailRequest
            {
                ToEmail = request.UserEmail,
                Body = "Your password reset link is " + token,
                Subject = "Reset password for " + request.UserEmail

            }); ;
            
        }
    }
}
