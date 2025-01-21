using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreshService.Commons.Responses
{
    public class FreshServiceCreateTicketResponse
    {
        public Ticket ticket { get; set; }
    }

    public class Ticket
    {
        public List<string> cc_emails { get; set; }
        public List<object> fwd_emails { get; set; }
        public List<string> reply_cc_emails { get; set; }
        public bool fr_escalated { get; set; }
        public bool spam { get; set; }
        public object email_config_id { get; set; }
        public object group_id { get; set; }
        public int priority { get; set; }
        public int requester_id { get; set; }
        public int requested_for_id { get; set; }
        public object responder_id { get; set; }
        public int source { get; set; }
        public int status { get; set; }
        public string subject { get; set; }
        public object to_emails { get; set; }
        public object department_id { get; set; }
        public int id { get; set; }
        public string type { get; set; }
        public DateTime due_by { get; set; }
        public DateTime fr_due_by { get; set; }
        public bool is_escalated { get; set; }
        public string description { get; set; }
        public string description_text { get; set; }
        public object category { get; set; }
        public object sub_category { get; set; }
        public object item_category { get; set; }
        public CustomFields custom_fields { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
        public List<object> tags { get; set; }
        public List<object> attachments { get; set; }
        public int workspace_id { get; set; }
        public string resolution_notes { get; set; }
        public string resolution_notes_html { get; set; }
    }

    public class CustomFields
    {
        public object auto_checkbox { get; set; }
    }
}
