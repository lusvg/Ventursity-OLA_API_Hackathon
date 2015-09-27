using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlaAPIHackathon.ServiceModel
{
    public class CancelBooking
    {
        public string status { get; set; }
        public string request_type { get; set; }
        public string header { get; set; }
        public string text { get; set; }
    }
}
