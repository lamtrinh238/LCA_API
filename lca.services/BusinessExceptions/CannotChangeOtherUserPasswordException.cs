using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCA.Service.BusinessExceptions
{
    [Serializable]
    public class CannotChangeOtherUserPasswordException: LcaException
    {
        public CannotChangeOtherUserPasswordException(): base("Forbidden: You cannot change other users' password.")
        {
            this.MessageCode = "CANNOT_CHANGE_OTHER_USER_PASSWORD";
            this.StatusCode = System.Net.HttpStatusCode.Unauthorized;
        }
    }
}
