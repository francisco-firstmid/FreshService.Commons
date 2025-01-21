using FreshService.Commons.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreshService.Commons.Responses
{
    public class GetAllLocationsResponse
    {
        public List<FreshServiceLocation> locations { get; set; }
    }
}
