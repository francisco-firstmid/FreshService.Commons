using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreshService.Commons.Requests
{
    public class FreshServiceOnboardingRequest
    {
        public Fields fields { get; set; }
        public class Fields
        {
            public string employee_name { get; set; }
            public string cf_last_name { get; set; }
            public string employee_email_address { get; set; }
            public string reporting_manager { get; set; }
            public string department_name { get; set; }
            public string cf_job_title { get; set; }
            public string cf_lob { get; set; }
            public long? cf_location { get; set; }
            public string doj { get; set; }
            public bool cf_check_if_this_person_is_a_rehire { get; set; }
            public string cf_date_of_joining { get; set; }
            public string actor_2 { get; set; }
            public string cf_today_s_date { get; set; }
            public string cf_preferred_name { get; set; }
        }
    }
}
