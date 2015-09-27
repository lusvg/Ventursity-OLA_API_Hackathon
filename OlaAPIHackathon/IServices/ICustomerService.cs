using OlaAPIHackathon.ServiceModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlaAPIHackathon.IServices
{
    public interface ICustomerService
    {
        Task<ProductAvailabilityRideEstimate> GetRideAvailability(string pickuplat, string  pickuplong, string category);
        Task<ProductAvailabilityRideEstimate> GetRideEstimate(string pickuplat, string pickuplong, string category, string droplat, string droplong);
        Task<BookRide> BookRide(string pickuplat, string pickuplong, string category, string pickupmode);
        Task<TrackRide> TrackRide();
        Task<CancelBooking> CancelBooking(string crn);
    }
}
