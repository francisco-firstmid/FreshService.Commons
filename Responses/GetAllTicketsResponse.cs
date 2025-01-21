using FreshService.Commons.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace FreshService.Commons.Responses
{
    public class GetAllTicketsResponse
    {
        public List<FreshServiceTicket> tickets { get; set; }
    }
}
