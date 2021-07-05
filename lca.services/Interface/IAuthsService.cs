using LCA.Services.Models;
using System.Collections.Generic;

namespace LCA.Services.Interface
{
    public interface IAuthsService
    {
        AuthenticateResponseModel Authenticate(AuthenticateRequestModel model);
        IEnumerable<UserModel> GetAll();
    }
}