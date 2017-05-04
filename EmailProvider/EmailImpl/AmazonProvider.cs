using System;

namespace EmailProvider.EmailImpl
{
    public class AmazonProvider : IEmailService
    {
        public bool sendMail(EmailInfo Obj)
        {
            //Do whatever is needed to send email via amazon
            return true;
        }
    }
}
