using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCA.Service.BusinessExceptions
{
    [Serializable]
    public class InvalidUserOrPasswordException : LcaException
    {
        public InvalidUserOrPasswordException() : base("Invalid user login name or password")
        {
            this.MessageCode = "INVALID_USER_LOGIN_NAME_OR_PASSWORD";
        }
    }
}
