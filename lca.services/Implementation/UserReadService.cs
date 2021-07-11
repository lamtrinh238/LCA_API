using LCA.Data.Context;
using LCA.Data.Domain;
using LCA.Service.Interface;
using LCA.Service.Models.filters;
using LCA.Services.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCA.Service.Implementation
{
    public class UserReadService : DbContextService, IUserReadService
    {

        public UserReadService(LcaDbContext dbContext): base(dbContext)
        {
        }
        public UserModel GetUserByID(int userID)
        {
            var user = this._dbContext.Users.Where(user => user.UsrId == userID).SingleOrDefault();
            return new UserModel(user);
        }

        public UserCompanyModel GetUserWithCompaniesByID(int userID)
        {
            var user = this._dbContext.Users.Where(user => user.UsrId == userID).AsNoTracking().SingleOrDefault();

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

        public IEnumerable<UserModel> Filter(UserFilter filter)
        {
            var query = this._dbContext.Users.Select(user => user);

            if (filter.LoginName != null)
            {
                query = query.Where(user => user.UsrLoginname.Contains(filter.LoginName));
            }

            if (filter.ID != null)
            {
                query = query.Where(user => user.UsrId == filter.ID);
            }

            if (filter.Type != null)
            {
                query = query.Where(user => user.UsrType == filter.Type);
            }

            if (filter.FullName != null)
            {
                query = query.Where(user => user.UsrFullname.Contains(filter.FullName));
            }

            if (filter.Email != null)
            {
                query = query.Where(user => user.UsrEmail.Contains(filter.Email));
            }

            return query.Skip(filter.SkipSize).Take(filter.PageSize).Select(user => new UserModel(user)).AsNoTracking().AsEnumerable();
        }
    }
}
