using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreshService.Commons.Models
{
    public class FreshServiceTicket
    {
        public string subject { get; set; }
        public object group_id { get; set; }
        public object department_id { get; set; }
        public string category { get; set; }
        public string sub_category { get; set; }
        public object item_category { get; set; }
        public object requester_id { get; set; }
        public object responder_id { get; set; }
        public DateTime due_by { get; set; }
        public bool fr_escalated { get; set; }
        public bool deleted { get; set; }
        public bool spam { get; set; }
        public object email_config_id { get; set; }
        public List<string> fwd_emails { get; set; }
        public List<string> reply_cc_emails { get; set; }
        public List<string> cc_emails { get; set; }
        public bool is_escalated { get; set; }
        public DateTime fr_due_by { get; set; }
        public int id { get; set; }
        public int priority { get; set; }
        public int status { get; set; }
        public int source { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
        public object requested_for_id { get; set; }
        public List<string> to_emails { get; set; }
        public string type { get; set; }
        public string description { get; set; }
        public string description_text { get; set; }
        public CustomFields custom_fields { get; set; }
        public int workspace_id { get; set; }
        public int tasks_dependency_type { get; set; }
    }

    public class CustomFields
    {
        public object call_phone_number { get; set; }
        public object issue_location { get; set; }
        public object jira_csat { get; set; }
        public object major_incident_type { get; set; }
        public object onsite { get; set; }
        public object sublocation { get; set; }
        public object vendor_contacted { get; set; }
        public object vendor_contacted_time { get; set; }
        public object business_impact { get; set; }
        public object impacted_locations { get; set; }
        public object no_of_customers_impacted { get; set; }
        public string resolution_notes { get; set; }
        public string location { get; set; }
        public object vendor_name { get; set; }
        public object vendor_phone { get; set; }
        public object ticket_number { get; set; }
        public object internal_prb { get; set; }
        public object internal_prb_notes { get; set; }
        public object notes { get; set; }
    }
}
