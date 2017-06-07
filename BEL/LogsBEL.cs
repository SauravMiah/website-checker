using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class LogsBEL
    {
        public long log_id { get; set; }
        public int web_id { get; set; }
        public DateTime log_date { get; set; }
        public string log_ip { get; set; }
        public int status { get; set; }
    }
}
