using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emailer
{
    class Program
    {
        private EmailInfo emailInfo;
        static void Main(string[] args)
        {
            GetEmailInfo();

            IEmailService objEmail;

            objEmail = new SMTPProvider();

            EmailSender_ConstInjection objSender = new EmailSender_ConstInjection(objEmail);
            objSender.Notification(emailInfo);

        }




        private EmailInfo GetEmailInfo()
        {
            emailInfo = new EmailInfo();
            emailInfo.EmailTo = "Test@test.com";
            emailInfo.EmailFrom = "Test@test.com";
            emailInfo.Subject = "Test";
            emailInfo.Body = "This is a test";
            return emailInfo;
        }

    }
        //This is the most common dependency injection.
        //When a class requires an instance of a dependency to work, we can supply that dependency through the class’s constructor. 
        public class EmailSender_ConstInjection
        {
            private IEmailService _iEmailService;
            //the implementation of the constructor is very simple 
            public EmailSender_ConstInjection(IEmailService _mailService)
            {
                this._iEmailService = _mailService;
            }
            public void Notification(EmailInfo ObjEmailInfo)
            {
                _iEmailService.SendMail(ObjEmailInfo);
            }
        }



    
}
