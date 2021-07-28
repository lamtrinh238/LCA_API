using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCA.Service.BusinessExceptions
{
    public class LcaException : Exception
    {
        public LcaException(string errorMessage) : base(errorMessage)
        {
        }
    }
}
