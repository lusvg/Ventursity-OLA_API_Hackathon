using OlaAPIHackathon.IServices;
using OlaAPIHackathon.ServiceModel;
using OlaAPIHackathon.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlaAPIHackathon.Services
{
    public class CustomerService : ICustomerService
    {
        public async Task<ProductAvailabilityRideEstimate> GetRideAvailability(string pickuplat, string pickuplong, string category)
        {
            string getRideAvailabilitURI = Settings.GetAPIUri(ServiceRoutes.Availability);
            Dictionary<string, string> param = new Dictionary<string, string>();
            param.Add("pickup_lat", pickuplat);
            param.Add("pickup_lng", pickuplong);
            param.Add("category", category);
            var getRideAvailability = new HttpRequest<ProductAvailabilityRideEstimate>(getRideAvailabilitURI, RequestMethod.GET, Settings.CurrentSettings.Server.DefaultHeaders, param, null, false, null, null);
            var serviceModel = await getRideAvailability.GetResponseForJSON();
            return serviceModel;
        }

        public async Task<ProductAvailabilityRideEstimate> GetRideEstimate(string pickuplat, string pickuplong, string category, string droplat, string droplong)
        {
            string getRideEstimateURI = Settings.GetAPIUri(ServiceRoutes.Estimate);
            Dictionary<string, string> param = new Dictionary<string, string>();
            param.Add("pickup_lat", pickuplat);
            param.Add("pickup_lng", pickuplong);
            param.Add("drop_lat", droplat);
            param.Add("drop_lng", droplong);
            param.Add("category", category);
            var getRideEstimate = new HttpRequest<ProductAvailabilityRideEstimate>(getRideEstimateURI, RequestMethod.GET, Settings.CurrentSettings.Server.DefaultHeaders, param, null, false, null, null);
            var serviceModel = await getRideEstimate.GetResponseForJSON();
            return serviceModel;
        }

        public async Task<BookRide> BookRide(string pickuplat, string pickuplong, string category, string pickupmode)
        {
            string getBookingURI = Settings.GetAPIUri(ServiceRoutes.Booking);
            Dictionary<string, string> param = new Dictionary<string, string>();
            param.Add("pickup_lat", pickuplat);
            param.Add("pickup_lng", pickuplong);
            param.Add("pickup_mode", pickupmode);
            param.Add("category", category);
            var getBooking = new HttpRequest<BookRide>(getBookingURI, RequestMethod.GET, Settings.CurrentSettings.Server.DefaultHeaders, param, null, false, null, null);
            var serviceModel = await getBooking.GetResponseForJSON();
            return serviceModel;
        }

        public async Task<TrackRide> TrackRide()
        {
            string getTrackRideURI = Settings.GetAPIUri(ServiceRoutes.Track);
            var getTrack = new HttpRequest<TrackRide>(getTrackRideURI, RequestMethod.GET, Settings.CurrentSettings.Server.DefaultHeaders, null, null, false, null, null);
            var serviceModel = await getTrack.GetResponseForJSON();
            return serviceModel;
        }

        public async Task<CancelBooking> CancelBooking(string crn)
        {
            string getCancelURI = Settings.GetAPIUri(ServiceRoutes.Booking);
            Dictionary<string, string> param = new Dictionary<string, string>();
            param.Add("crn", crn);
            var getcancel = new HttpRequest<CancelBooking>(getCancelURI, RequestMethod.GET, Settings.CurrentSettings.Server.DefaultHeaders, param, null, false, null, null);
            var serviceModel = await getcancel.GetResponseForJSON();
            return serviceModel;
        }

    }
}
