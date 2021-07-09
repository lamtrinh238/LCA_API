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
    public class UserService : IUserService
    {
        private readonly LcaDbContext _dbContext;
        public UserService(LcaDbContext dbContext)
        {
            this._dbContext = dbContext;
        }
        public UserModel GetUserByID(int userID)
        {
            var user = this._dbContext.Users.Where(user => user.UsrId == userID).SingleOrDefault();

            var companiesOfUser = this._dbContext.Companies.Join(this._dbContext.Usrlinks,
                comp => comp.ComId,
                link => link.ComId,
                (comp, link) => new
                {
                    Company = comp,
                    UserID = link.UsrId
                }).Where(compUser => compUser.UserID == user.UsrId).Select(compUser => compUser.Company);

            return new UserModel(user);
        }

        public UserCompanyModel GetUserWithCompaniesByID(int userID)
        {
            var user = this._dbContext.Users.Where(user => user.UsrId == userID).SingleOrDefault();

            var companiesOfUser = this._dbContext.Companies.Join(this._dbContext.Usrlinks,
               comp => comp.ComId,
               link => link.ComId,
               (comp, link) => new
               {
                   Company = comp,
                   UserID = link.UsrId
               }).Where(compUser => compUser.UserID == user.UsrId).Select(compUser => compUser.Company).ToHashSet();

            return new UserCompanyModel(user, companiesOfUser);
        }
    }
}
