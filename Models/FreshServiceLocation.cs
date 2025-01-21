using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreshService.Commons.Models
{
    public class FreshServiceLocation
    {
        public Address address { get; set; }
        public string? contact_name { get; set; }
        public DateTime created_at { get; set; }
        public string email { get; set; }
        public long? id { get; set; }
        public string name { get; set; }
        public long? parent_location_id { get; set; }
        public string phone { get; set; }
        public string primary_contact_id { get; set; }
        public DateTime updated_at { get; set; }
    }

    public class Address
    {
        public string line1 { get; set; }
        public string line2 { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string country { get; set; }
        public string zipcode { get; set; }
    }
}
