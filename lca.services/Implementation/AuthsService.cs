using LCA.Data.Context;
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
        
        private readonly LcaDbContext _dbContext;

        private readonly AppSettingsModel _appSettings;

        public AuthsService(IOptions<AppSettingsModel> appSettings, LcaDbContext dbContext)
        {
            _appSettings = appSettings.Value;
            _dbContext = dbContext;
        }

        public AuthenticateResponseModel Authenticate(AuthenticateRequestModel model)
        {
            var user = new UserModel(_dbContext.Users.SingleOrDefault(x => x.UsrLoginname == model.Username && x.UsrPassword == model.Password));

            // HARD CODE ROLES
            user.Roles = "Admin";

            // return null if user not found
            if (user == null) return null;

            // authentication successful so generate jwt token
            var token = generateJwtToken(user);

            return new AuthenticateResponseModel(user, token);
        }

        public IEnumerable<UserModel> GetAll()
        {
            return _dbContext.Users.Take(10).Select(s => new UserModel(s));
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