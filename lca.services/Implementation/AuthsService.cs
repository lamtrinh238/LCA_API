using LCA.Data.Context;
using LCA.Service.Interface;
using LCA.Services.Interface;
using LCA.Services.Models;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;

namespace LCA.Services.Implementation
{
    public class AuthsService : IAuthsService
    {
        
        private readonly IUserReadService _userReadService;

        private readonly AppSettingsModel _appSettings;

        public AuthsService(IOptions<AppSettingsModel> appSettings, IUserReadService userReadService)
        {
            _appSettings = appSettings.Value;
            this._userReadService = userReadService;
         }

        public AuthenticateResponseModel Authenticate(AuthenticateRequestModel model)
        {
            var user = this._userReadService.GetUserByUserNameAndPassword(model.Username, model.Password);

            // HARD CODE ROLES
            user.Roles = "Admin";

            // return null if user not found
            if (user == null) return null;

            // authentication successful so generate jwt token
            var token = generateJwtToken(user);

            return new AuthenticateResponseModel(user, token);
        }

        // helper methods
        private string generateJwtToken(UserModel user)
        {
            // generate token that is valid for 7 days
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_appSettings.Secret);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[] { new Claim("id", user.UsrId.ToString()), new Claim("roles", user.Roles.ToString()) }),
                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }
    }
}