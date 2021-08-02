using LCA.Services.Models;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCA.Service.Interface
{
    public interface IJsonWebTokenService
    {
        string GenerateToken(UserModel user, DateTime expireTime);
        JwtSecurityToken ValidateToken(string token);
    }
}
