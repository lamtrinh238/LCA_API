using LCA.Service.BusinessExceptions;
using LCA.Service.Interface;
using LCA.Service.Models;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace LCA.Service.Implementation
{
    public class EmailService : IEmailService
    {
        private readonly MailSettings _mailSettings;
        public EmailService(IOptions<MailSettings> mailSettings)
        {
            _mailSettings = mailSettings.Value;
        }

        public void SendEmail(SendEmailRequest request)
        {
            MailMessage msg = new();

            msg.To.Add(request.ToEmail);
            msg.Sender = new MailAddress(_mailSettings.Mail);
            msg.From = new MailAddress(_mailSettings.Mail);

            msg.Subject = request.Subject;
            msg.SubjectEncoding = System.Text.Encoding.UTF8;

            msg.Body = request.Body;
            msg.BodyEncoding = System.Text.Encoding.UTF8;
            msg.IsBodyHtml = true;

            msg.Priority = MailPriority.High;

            SmtpClient client = new()
            {
                Credentials = new System.Net.NetworkCredential(_mailSettings.Mail, _mailSettings.Password),
                Port = _mailSettings.Port, //25 or use 587 or 465
                Host = _mailSettings.Host,
                EnableSsl = true
            };

            try
            {
                client.Send(msg);
            } catch(Exception)
            {
                throw new EmailCannotBeSentException();
            }           

        }
    }
}
