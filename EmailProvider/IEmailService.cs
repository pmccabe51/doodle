using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailProvider
{
   public interface IEmailService
    {
        //test
        bool sendMail(EmailInfo Obj);
    }
}
