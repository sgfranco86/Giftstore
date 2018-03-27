using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giftshop.Domain
{
    public class User
    {
        public decimal USER_ID { get; set; }
        public string PASSWORDX { get; set; }
        public int SITE_ID { get; set; }
        public string ACTIVE { get; set; }
        public DateTime INACTIVE_DATE { get; set; }
        public string PREFIX { get; set; }
        public string LAST_NAME { get; set; }
        public string FIRST_NAME { get; set; }
        public string SUFFIX { get; set; }
        public string TITLE { get; set; }
        public string ADMIN_ACCESS { get; set; }
        public string SETUP_ACCESS { get; set; }
     
    }
}
