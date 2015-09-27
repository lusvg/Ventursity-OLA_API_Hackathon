using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlaAPIHackathon.ServiceModel
{
    public class Duration
    {
        public int value { get; set; }
        public string unit { get; set; }
    }

    public class Distance
    {
        public double value { get; set; }
        public string unit { get; set; }
    }

    public class TrackRide
    {
        public string status { get; set; }
        public string request_type { get; set; }
        public string booking_status { get; set; }
        public string crn { get; set; }
        public Duration duration { get; set; }
        public Distance distance { get; set; }
        public double driver_lat { get; set; }
        public double driver_lng { get; set; }
    }
}
