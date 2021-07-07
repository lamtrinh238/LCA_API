using LCA.Data.Context;
using LCA.Service.Interface;
using LCA.Services.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCA.Service.Implementation
{
    public class UserService : IUserService
    {
        private readonly LcaDbContext _dbContext;
        public UserService(LcaDbContext dbContext)
        {
            this._dbContext = dbContext;
        }
        public UserModel GetUserByID(int userID)
        {
            var user = this._dbContext.Users.Include(user => user.Usrlinks).Where(user => user.UsrId == userID).SingleOrDefault();
            return new UserModel(user);
        }
    }
}
