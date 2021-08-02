using LCA.Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCA.Service.Interface
{
    public interface IEmailService
    {
        void SendEmail(SendEmailRequest request);
    }
}
