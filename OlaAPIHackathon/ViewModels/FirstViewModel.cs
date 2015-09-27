using Cirrious.CrossCore;
using Cirrious.MvvmCross.Plugins.Location;
using Cirrious.MvvmCross.ViewModels;
using OlaAPIHackathon.IServices;
using OlaAPIHackathon.ServiceModel;
using System;
using System.Collections.ObjectModel;

namespace OlaAPIHackathon.ViewModels
{
    public class FirstViewModel : MvxViewModel
    {
        private readonly ICustomerService _customerService;
        private readonly IMvxLocationWatcher _watcher;
        public FirstViewModel(ICustomerService customerService, IMvxLocationWatcher watcher)
        {
            _customerService = customerService;
            _watcher = watcher;
            if (_watcher != null)
            {
                if (!_watcher.Started)
                    _watcher.Start(new MvxLocationOptions(), OnLocationFound, OnError);
            }
            if (string.IsNullOrWhiteSpace(Lat) || string.IsNullOrWhiteSpace(Lon))
            {
                Lat = "12.950545";
                Lon = "77.642149";
            }
        }
            
        public bool isComingfromViewModel { get; set; }
        public string Lat { get; set; }
        public string Lon { get; set; }
        public static string MessageString { get; set; }
        public static string CategoryStr { get; set; }

        public async void GetAvailability(string category)
        {

            if (string.IsNullOrWhiteSpace(Lat) || string.IsNullOrWhiteSpace(Lon))
            {
                Lat = "12.950545";
                Lon = "77.642149";
            }
            CategoryStr = category;
            var GetAvailability = await _customerService.GetRideAvailability(Lat, Lon, category);

            if (GetAvailability == null || GetAvailability.categories == null)
            {
                MessageString = "No Cabs Available!!! Please try again later.";
                Reload();
            }
            else
            {
                var last = GetAvailability.categories.FindLast(c => c.id == c.id);
                MessageString = category + " is available. Distance " + last.distance.ToString() + " " + last.distance_unit.ToString() + " Estimated arrival time " + last.eta.ToString() + " " + last.time_unit.ToString() + " .";
                Reload();
                //ObservableCollection<Category> cat = GetAvailability.categories.ToList();
                //var ob = cat.FirstOrDefault();
                //String eta = ob.eta;
                //string etaunit = ob.time_unit;
                //String dis = ob.distance;
                //string disunit = ob.distance_unit;
            }
        }

        private void Reload()
        {
            this.ShowViewModel<FirstViewModel>();
        }

        private void OnLocationFound(MvxGeoLocation location)
        {
            try
            {
                Lat = location.Coordinates.Latitude.ToString();
                Lon = location.Coordinates.Longitude.ToString();
            }
            catch (Exception ex)
            {

            }
        }

        private async void OnError(MvxLocationError error)
        {
            try
            {
                string Lat, Lng;
                Mvx.Error("Seen location error {0}", error.Code);
            }
            catch (Exception e)
            {

            }
        }

        public static string BookingMessage { get; set; }
        public static string CarNo { get; set; }
        public static string CarModel { get; set; }
        public static string DriverNo { get; set; }
        public static bool IsBookRide { get; set; }
        public static string crn {get;set;}
        public async void BookRide(string pickupmode)
        {
            var booking = await _customerService.BookRide(Lat, Lon, CategoryStr, pickupmode);
            BookingMessage = booking.driver_name + " will pick you in next " + booking.eta + " min. ";
            CarNo = booking.cab_number;
            CarModel = booking.car_model;
            DriverNo = booking.driver_number;
            Reload();
        }

        public async void Cancel()
        {
            var cancel = _customerService.CancelBooking(crn);
        }
             
    }
}
