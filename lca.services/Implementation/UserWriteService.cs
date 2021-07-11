using LCA.Data.Context;
using LCA.Data.Domain;
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
    public class UserWriteService : DbContextService, IUserWriteService
    {
        public UserWriteService(LcaDbContext dbContext): base(dbContext)
        {

        }
        public long CreateUser(UserModel userModel)
        {
            var newUser = new User
            {
                UsrLoginname = userModel.UsrLoginname,
                UsrType = userModel.UsrType,
                UsrFullname = userModel.UsrFullname,
                UsrEmail = userModel.UsrEmail,
                UsrAdd = userModel.UsrAdd,
                UsrProid = userModel.UsrProid,
                UsrPhone1 = userModel.UsrPhone1,
                UsrPhone2 = userModel.UsrPhone2,
                UsrZip = userModel.UsrZip,
                UsrStatus = userModel.UsrStatus,
                UsrCreatedby = userModel.UsrCreatedby,
                UsrCity = userModel.UsrCity,
                UsrOrganization = userModel.UsrOrganization,
                UsrTraining = userModel.UsrTraining,
                UsrGuid = userModel.UsrGuid,
                UsrActive = userModel.UsrActive,
                UsrApproved = userModel.UsrApproved,
            };

            this._dbContext.Entry<User>(newUser).State = EntityState.Added;
            this._dbContext.SaveChanges();
            return newUser.UsrId;
        }
    }
}
