using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class WebsiteBEL
    {
        public int webID { get; set; }
        public string web_name { get; set; }
        public string web_url { get; set; }
        public int sort_order { get; set; }
        public int server_id { get; set; }
        public int isDeleted { get; set; }
    }
}
