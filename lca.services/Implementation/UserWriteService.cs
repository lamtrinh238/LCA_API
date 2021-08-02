using LCA.Data.Context;
using LCA.Data.Domain;
using LCA.Service.BusinessExceptions;
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
        public UserWriteService(LcaDbContext dbContext) : base(dbContext)
        {

        }



        public long CreateUser(UserModel userModel)
        {
            if (_dbContext.Users.Where(c=> c.UsrLoginname.Equals(userModel.UsrLoginname) 
                    || c.UsrEmail.Equals(userModel.UsrEmail)).Any())
            {
                throw new UserAlreadyExistException();
            }

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
                UsrComments = userModel.UsrComments
            };

            this._dbContext.Entry<User>(newUser).State = EntityState.Added;
            this._dbContext.SaveChanges();
            return newUser.UsrId;
        }

        public long UpdateUser(long userID, UserModel userModel)
        {
            var existingUser = this._dbContext.Users.SingleOrDefault(user => user.UsrId == userID);
            if (existingUser == null)
            {
                throw new NotSupportedException();
            }
            existingUser.UsrType = userModel.UsrType;
            existingUser.UsrFullname = userModel.UsrFullname;
            existingUser.UsrEmail = userModel.UsrEmail;
            existingUser.UsrAdd = userModel.UsrAdd;
            existingUser.UsrProid = userModel.UsrProid;
            existingUser.UsrPhone1 = userModel.UsrPhone1;
            existingUser.UsrPhone2 = userModel.UsrPhone2;
            existingUser.UsrZip = userModel.UsrZip;
            existingUser.UsrStatus = userModel.UsrStatus;
            existingUser.UsrCity = userModel.UsrCity;
            existingUser.UsrOrganization = userModel.UsrOrganization;
            existingUser.UsrTraining = userModel.UsrTraining;
            existingUser.UsrGuid = userModel.UsrGuid;
            existingUser.UsrActive = userModel.UsrActive;
            existingUser.UsrApproved = userModel.UsrApproved;
            existingUser.UsrComments = userModel.UsrComments;

            this._dbContext.Entry<User>(existingUser).State = EntityState.Modified;
            this._dbContext.SaveChanges();
            return userID;
        }

        public long ChangePassword(long userID, PasswordChangeModel model)
        {
            var userInfo = this._dbContext.Users.SingleOrDefault(user => user.UsrId == userID && user.UsrPassword.Equals(model.CurrentPassword));

            if (userInfo == null)
            {
                throw new InvalidUserOrPasswordException();
            }

            userInfo.UsrPassword = model.NewPassword;
            this._dbContext.Entry<User>(userInfo).State = EntityState.Modified;
            this._dbContext.SaveChanges();
            return userInfo.UsrId;
        }
    }
}
