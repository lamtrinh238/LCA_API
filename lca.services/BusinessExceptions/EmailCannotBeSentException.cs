using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCA.Service.BusinessExceptions
{
    [Serializable]
    public class EmailCannotBeSentException : LcaException
    {
        public EmailCannotBeSentException(): base("Failed to send the email.")
        {
            this.Code = "FAILED_TO_SEND_EMAIL";
            this.StatusCode = 401;
        }
    }
}
