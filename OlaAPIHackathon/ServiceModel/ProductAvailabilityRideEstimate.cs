using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlaAPIHackathon.ServiceModel
{
    public class ProductAvailabilityRideEstimate
    {
        public List<Category> categories { get; set; }
        public RideEstimate ride_estimate { get; set; }
    }

    public class FareBreakup
    {
        public string type { get; set; }
        public string minimum_distance { get; set; }
        public string minimum_time { get; set; }
        public string base_fare { get; set; }
        public string cost_per_distance { get; set; }
        public string waiting_cost_per_minute { get; set; }
        public string ride_cost_per_minute { get; set; }
        public List<object> surcharge { get; set; }
    }

    public class Category
    {
        public string id { get; set; }
        public string display_name { get; set; }
        public string currency { get; set; }
        public string distance_unit { get; set; }
        public string time_unit { get; set; }
        public string eta { get; set; }
        public string distance { get; set; }
        public string image { get; set; }
        public List<FareBreakup> fare_breakup { get; set; }
    }

    public class RideEstimate
    {
        public string category { get; set; }
        public double distance { get; set; }
        public int travel_time_in_minutes { get; set; }
        public int amount_min { get; set; }
        public int amount_max { get; set; }
    }
}
