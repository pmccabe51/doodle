using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emailer
{
 public   class EmailInfo
    {
        public string Body { get; set; }
        public string Subject { get; set; }
        public string EmailTo { get; set; }
        public string EmailFrom { get; set; }
        public List<String> AttachmentFilePaths { get; set; }
    }
}
