using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlaAPIHackathon.ServiceModel
{
    public class BookRide
    {
        public string crn { get; set; }
        public string driver_name { get; set; }
        public string driver_number { get; set; }
        public string cab_type { get; set; }
        public string cab_number { get; set; }
        public string car_model { get; set; }
        public int eta { get; set; }
        public double driver_lat { get; set; }
        public double driver_lng { get; set; }
    }
}
