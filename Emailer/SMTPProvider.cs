using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Emailer
{
    class SMTPProvider : IEmailService
    {
        public bool sendMail(EmailInfo emailInfo)
        {
            MailMessage message = new MailMessage();
            message.To.Add(emailInfo.EmailTo);
            message.Subject = emailInfo.Subject;
            message.From = new System.Net.Mail.MailAddress(emailInfo.EmailFrom);
            message.Body = emailInfo.Body;

            SmtpClient smtp = new SmtpClient("localhost");
            //smtp.Port = 25;
            try
            {
                smtp.Send(message);
                return true;
            }
            catch (Exception ex)
            {
                //PMC: in real world would log something here
                return false;
            }
        }

    }
}
