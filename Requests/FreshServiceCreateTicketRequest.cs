using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreshService.Commons.Requests
{
    public class FreshServiceCreateTicketRequest
    {
        public string description { get; set; }
        public string subject { get; set; }
        public string email { get; set; }
        public int priority { get; set; }
        public int status { get; set; }
        public List<string> cc_emails { get; set; }
        public int workspace_id { get; set; }
    }
}
