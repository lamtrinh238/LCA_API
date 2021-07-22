﻿using LCA.Service.Models.filters;
using LCA.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCA.Service.Interface
{
    public interface IUserReadService
    {
        UserModel GetUserByID(int userID);
        UserCompanyModel GetUserWithCompaniesByID(int userID);
        UserCompanyModel GetUserByUserNameAndPassword(string userName, string password);
        public IEnumerable<UserModel> Filter(BaseFilter filter);
    }
}
