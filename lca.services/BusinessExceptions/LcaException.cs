using System;
using System.Collections.Generic;
using System.Linq;
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
        }

        public Object ToSerializableObject()
        {

            return new
            {
                Code,
                StatusCode,
                Message
            };
        }


        public string Code { get; set; }
        public int StatusCode { get; set; }
    }
}
