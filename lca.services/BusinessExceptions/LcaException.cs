using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace LCA.Service.BusinessExceptions
{
    [Serializable]
    public class LcaException : Exception
    {

        public LcaException(string errorMessage) : base(errorMessage)
        {
            StatusCode = HttpStatusCode.BadRequest;
        }

        public LcaException(string message, params object[] args) : base(String.Format(CultureInfo.CurrentCulture, message, args))
        {
            StatusCode = HttpStatusCode.BadRequest;
        }

        public Object ToSerializableObject()
        {

            return new
            {
                MessageCode,
                StatusCode,
                Message
            };
        }


        public string MessageCode { get; set; }
        public HttpStatusCode StatusCode { get; set; }
    }
}
