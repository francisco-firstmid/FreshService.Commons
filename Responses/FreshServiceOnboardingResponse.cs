using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreshService.Commons.Responses
{
    public class FreshServiceOnboardingResponse
    {
        public OnboardingRequest onboarding_request { get; set; }
        public class Actors
        {
            [JsonProperty("HR Manager")]
            public HRManager HRManager { get; set; }
        }

        public class CfAllUsers
        {
            public int id { get; set; }
            public string first_name { get; set; }
            public string last_name { get; set; }
            public string email { get; set; }
            public int mobile { get; set; }
            public int phone { get; set; }
        }

        public class CfAssets
        {
            public int id { get; set; }
            public string name { get; set; }
            public int display_id { get; set; }
        }

        public class CfDepartment
        {
            public int id { get; set; }
            public string name { get; set; }
            public string description { get; set; }
        }

        public class CfLocation
        {
            public int id { get; set; }
            public string name { get; set; }
        }

        public class Fields
        {
            public string cf_employee_name { get; set; }
            public string cf_job_title { get; set; }
            public string cf_date_of_joining { get; set; }
            public int cf_all_users { get; set; }
            public object cf_agents { get; set; }
            public object cf_requesters { get; set; }
            public int cf_department { get; set; }
            public int cf_assets { get; set; }
            public int cf_location { get; set; }
            public string cf_hierarchy { get; set; }
            public object cf_online_portfolio { get; set; }
            public object cf_additional_info { get; set; }
            public object cf_experience { get; set; }
            public bool cf_verified { get; set; }
            public object cf_category { get; set; }
            public string cf_subcategory { get; set; }
            public List<string> msf_area_of_expertise { get; set; }
        }

        public class HRManager
        {
            public string email { get; set; }
            public string name { get; set; }
            public string response_status { get; set; }
        }

        public class LookupValues
        {
            public CfAllUsers cf_all_users { get; set; }
            public CfDepartment cf_department { get; set; }
            public CfAssets cf_assets { get; set; }
            public CfLocation cf_location { get; set; }
            public List<MsfPreferredLocation> msf_preferred_locations { get; set; }
        }

        public class MsfPreferredLocation
        {
            public int id { get; set; }
            public string name { get; set; }
        }

        public class OnboardingRequest
        {
            public int id { get; set; }
            public DateTime created_at { get; set; }
            public DateTime updated_at { get; set; }
            public int status { get; set; }
            public string subject { get; set; }
            public object ticket_id { get; set; }
            public Actors actors { get; set; }
            public Fields fields { get; set; }
            public LookupValues lookup_values { get; set; }
        }
    }
}
