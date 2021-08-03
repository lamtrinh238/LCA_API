using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCA.Service.BusinessExceptions
{
    public class CannotValidateResetPasswordTokenException : LcaException
    {
        public CannotValidateResetPasswordTokenException() : base("Cannot validate reset password token")
        {
            MessageCode = "CANNOT_VALIDATE_RESET_PASSWORD_TOKEN";
            StatusCode = System.Net.HttpStatusCode.BadRequest;
        }
    }
}
