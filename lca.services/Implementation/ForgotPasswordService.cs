using LCA.Data.Context;
using LCA.Data.Domain;
using LCA.Service.BusinessExceptions;
using LCA.Service.Interface;
using LCA.Service.Models;
using LCA.Services.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCA.Service.Implementation
{
    public class ForgotPasswordService : IForgotPasswordService
    {
        private readonly LcaDbContext _lcaDbContext;
        private readonly IUserReadService _userReadService;
        private readonly IEmailService _emailService;
        private readonly IJsonWebTokenService _jsonWebTokenService;
        public ForgotPasswordService(
            LcaDbContext lcaDbContext,
            IUserReadService userReadService, 
            IEmailService emailService, 
            IJsonWebTokenService jsonWebTokenService)
        {
            _lcaDbContext = lcaDbContext;
            _userReadService = userReadService;
            _emailService = emailService;
            _jsonWebTokenService = jsonWebTokenService;
        }

        public void CreateForgotPasswordRequest(ForgotPasswordModel request)
        {
            UserModel user = _userReadService.GetUserByEmail(request.UserEmail);

            if(user == null)
            {
                throw new UserNotFoundException();
            }

            // TODO;
            string token = this._jsonWebTokenService.GenerateToken(user, DateTime.UtcNow.AddDays(1));
            _emailService.SendEmail(new SendEmailRequest
            {
                ToEmail = request.UserEmail,
                Body = $"Your password reset link is https://lca-dev.web.app/passport/reset-password?token={token}",
                Subject = "Reset password for " + request.UserEmail
            }); ;
            
        }

        public void ResetPassword(ResetPasswordModel request)
        {
            JwtSecurityToken jwtToken = null;
            try
            {
                jwtToken = this._jsonWebTokenService.ValidateToken(request.Token);
            } catch (Exception)
            {
                throw new CannotValidateResetPasswordTokenException();
            }

            var userId = long.Parse(jwtToken.Claims.First(x => x.Type == "id").Value);
            User user = _lcaDbContext.Users.SingleOrDefault(u => u.UsrId == userId);

            if(user == null)
            {
                throw new UserNotFoundException();
            }

            user.UsrPassword = request.Password;
            _lcaDbContext.Entry<User>(user).State = EntityState.Modified;
            _lcaDbContext.SaveChanges();
        }
    }
}
