using LCA.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCA.Service.Interface
{
    public interface IUserWriteService
    {
        long CreateUser(UserModel userModel);
        long UpdateUser(int userID, UserModel user);
    }
}
