using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace LCA.Service.BusinessExceptions
{
    [Serializable]
    public class UserAlreadyExistException : LcaException
    {
        public UserAlreadyExistException() : base("Invalid user login name or password")
        {
            this.Code = "USER_ALREADY_EXIST";
            this.StatusCode = (int)HttpStatusCode.BadRequest;
        }
    }
}
