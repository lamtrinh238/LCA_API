using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCA.Service.BusinessExceptions
{
    [Serializable]
    public class UserNotFoundException : LcaException
    {
        public UserNotFoundException() : base("User does not exist.")
        {
            MessageCode = "USER_NOT_FOUND";
            StatusCode = System.Net.HttpStatusCode.NotFound;
        }
    }
}

