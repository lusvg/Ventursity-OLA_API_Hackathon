using Bing.Maps;
using Cirrious.MvvmCross.WindowsCommon.Views;
using OlaAPIHackathon.ViewModels;
using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;

namespace OlaAPIHackathon.Win.Views
{
    public sealed partial class FirstView : MvxWindowsPage
    {
        public FirstView()
        {
            this.InitializeComponent();
            progress.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            if(isRideBooking)
            {
                BookRide.Visibility = Visibility.Visible;
            }
            else
            {
                BookRide.Visibility = Visibility.Collapsed;
            }
        }
        
       

        public new FirstViewModel ViewModel
        {
            get { return (FirstViewModel)base.ViewModel; }
            set { base.ViewModel = value; }
        }

        private void MapObj_Loaded(object sender, RoutedEventArgs e)
        {
            OlaWinMap.Credentials = "Aqn7OafrH3LDlnZMJfV4vyyUGBEM_NO93OtUq3m4Ebtkzgkyzz1G5j8YAi5UT0_j";
            AddPinsToMap();
            OlaWinMap.Height = 400;
        }

        private void AddPinsToMap()
        {

            if (ViewModel.Lat != null && ViewModel.Lon != null)
            {
                Pushpin pushpin = new Pushpin();
                OlaWinMap.Center = new Location(Convert.ToDouble(ViewModel.Lat), Convert.ToDouble(ViewModel.Lon));
                //pushpin.Text = "You are here";
                pushpin.Width = 100;
                pushpin.Height = 100;
                MapLayer.SetPosition(pushpin, OlaWinMap.Center);
                OlaWinMap.Children.Add(pushpin);
            }
        }

        private void GetSedanAvailability(object sender, TappedRoutedEventArgs e)
        {
            ViewModel.GetAvailability("Sedan");
            ViewModel.isComingfromViewModel = true;
            progress.Visibility = Windows.UI.Xaml.Visibility.Visible; 
        }

        private void GetPrimeAvailability(object sender, TappedRoutedEventArgs e)
        {
            ViewModel.GetAvailability("Prime");
            ViewModel.isComingfromViewModel = true;
            progress.Visibility = Windows.UI.Xaml.Visibility.Visible; 
        }

        private void GetMiniAvailability(object sender, TappedRoutedEventArgs e)
        {
            ViewModel.GetAvailability("Mini");
            ViewModel.isComingfromViewModel = true;
            progress.Visibility = Windows.UI.Xaml.Visibility.Visible; 
        }
        public static bool isRideBooking = false;
        private void BookNow(object sender, RoutedEventArgs e)
        {
            ViewModel.BookRide("NOW");
            isRideBooking = true;
            BookRide.Visibility = Visibility.Visible;
        }

        private void TrackRide(object sender, RoutedEventArgs e)
        {

        }

        private void CancelRide(object sender, RoutedEventArgs e)
        {
            ViewModel.Cancel();
        }
 
    }
}
