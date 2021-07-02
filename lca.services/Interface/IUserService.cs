using LCA.Services.Models;
using System.Collections.Generic;

namespace LCA.Services.Interface
{
    public interface IUserService
    {
        AuthenticateResponse Authenticate(AuthenticateRequest model);
        IEnumerable<User> GetAll();
        User GetById(int id);
    }
}