using System;
using System.Threading.Tasks;
using Xamarin.Essentials;

namespace Twotter.ViewModels
{
    public class LocationViewModel : BaseViewModel
    {
        private string _latitude;
        private string _longitude;
        private string _altitude;


        public LocationViewModel()
        {
            Task.Run(async () => { await GetGeoLocationAsync(); });
        }

        public string Latitude
        {
            get => _latitude;
            set
            {
                _latitude = value;
                OnPropertyChanged();
            }

        }

        public string Longitude
        {
            get => _longitude;
            set
            {
                _longitude = value;
                OnPropertyChanged();
            }

        }

        public string Altitude
        {
            get => _altitude;
            set
            {
                _altitude = value;
                OnPropertyChanged();
            }

        }


        public async Task GetGeoLocationAsync()
        {
            var location = await Geolocation.GetLastKnownLocationAsync();

            Latitude = location.Latitude.ToString();
            Longitude = location.Longitude.ToString();
            Altitude = location.Altitude.ToString();
            Console.WriteLine("hara");
            Console.WriteLine($"Latitude: {location.Latitude}, Longitude: {location.Longitude}, Altitude: {location.Altitude}");
        }
    }
}
