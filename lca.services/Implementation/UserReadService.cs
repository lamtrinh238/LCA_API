﻿using LCA.Data.Context;
using LCA.Data.Domain;
using LCA.Service.BusinessExceptions;
using LCA.Service.Helpers;
using LCA.Service.Interface;
using LCA.Service.Models.filters;
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
    public class UserReadService : DbContextService, IUserReadService
    {

        public UserReadService(LcaDbContext dbContext) : base(dbContext)
        {
        }
        public UserModel GetUserByID(long userID)
        {
            var user = this._dbContext.Users.Where(user => user.UsrId == userID).SingleOrDefault();
            if (user == null) throw new UserNotFoundException();
            return new UserModel(user);
        }

        public UserCompanyModel GetUserWithCompaniesByID(long userID)
        {
            var user = this._dbContext.Users.Where(user => user.UsrId == userID).AsNoTracking().SingleOrDefault();

            if (user == null) throw new UserNotFoundException();

            var companiesOfUser = this._dbContext.Companies.Join(this._dbContext.Usrlinks,
               comp => comp.ComId,
               link => link.ComId,
               (comp, link) => new
               {
                   Company = comp,
                   UserID = link.UsrId
               }).Where(compUser => compUser.UserID == user.UsrId).AsNoTracking().Select(compUser => compUser.Company).ToHashSet();

            return new UserCompanyModel(user, companiesOfUser);
        }

        public IEnumerable<UserModel> Filter(BaseFilter filter)
        {
            var query = from user in _dbContext.Users
                        select(new UserModel() 
                        {
                            UsrId = user.UsrId,
                            UsrLoginname = user.UsrLoginname,
                            UsrPassword = user.UsrPassword,
                            UsrType = user.UsrType,
                            UsrFullname = user.UsrFullname,
                            UsrEmail = user.UsrEmail,
                            UsrAdd = user.UsrAdd,
                            UsrProid = user.UsrProid,
                            UsrZip = user.UsrZip,
                            UsrPhone1 = user.UsrPhone1,
                            UsrPhone2 = user.UsrPhone2,
                            UsrStatus = user.UsrStatus,
                            UsrCreatedttm = user.UsrCreatedttm,
                            UsrCreatedby = user.UsrCreatedby,
                            UsrResetpwd = user.UsrResetpwd,
                            UsrCity = user.UsrCity,
                            UsrOrganization = user.UsrOrganization,
                            UsrCompid = user.UsrCompid,
                            UsrTraining = user.UsrTraining,
                            UsrTrainingValid = user.UsrTrainingValid,
                            UsrGdpr = user.UsrGdpr,
                            LastLogin = user.LastLogin,
                            UsrGuid = user.UsrGuid,
                            UsrActive = user.UsrActive,
                            UsrApproved = user.UsrApproved,
                            UsrComments = user.UsrComments,
                        });

            string sqlStr = query.ApplyFilterToQueryString(filter);
            List<UserModel> users = _dbContext.RawSqlQuery(sqlStr).ConvertDataTable<UserModel>();
            return users;
        }

        public UserCompanyModel GetUserByUserNameAndPassword(string userName, string password)
        {
            var user = this._dbContext.Users.Where(user => user.UsrLoginname.Equals(userName) && user.UsrPassword.Equals(password)).AsNoTracking().SingleOrDefault();

            // return null if user not found
            if (user == null) throw new InvalidUserOrPasswordException();

            var companiesOfUser = this._dbContext.Companies.Join(this._dbContext.Usrlinks,
               comp => comp.ComId,
               link => link.ComId,
               (comp, link) => new
               {
                   Company = comp,
                   UserID = link.UsrId
               }).Where(compUser => compUser.UserID == user.UsrId).AsNoTracking().Select(compUser => compUser.Company).ToHashSet();

            return new UserCompanyModel(user, companiesOfUser);
        }

        public UserModel GetUserByEmail(string userEmail)
        {
            var user = this._dbContext.Users.Where(user => user.UsrEmail.Equals(userEmail)).SingleOrDefault();

            if (user == null) throw new UserNotFoundException();

            return new UserModel(user);
        }

        public UserModel GetUserByToken(JwtSecurityToken jwtToken)
        {
            var userId = long.Parse(jwtToken.Claims.First(x => x.Type == "id").Value);

            return this.GetUserByID(userId);
        }

        public IEnumerable<UserModel> FilterByCompany(int clientID)
        {
            var users = _dbContext.Users.Join(_dbContext.Usrlinks,
                 usr => usr.UsrId,
                 link => link.UsrId,
                 (usr, link) => new
                 {
                     User = usr,
                     ComID = link.ComId
                 })
                .Where(compUser => compUser.ComID == clientID)
                .AsNoTracking()
                .Select(compUser => new UserModel(compUser.User))
                .ToHashSet();

            return users;
        }
    }
}
