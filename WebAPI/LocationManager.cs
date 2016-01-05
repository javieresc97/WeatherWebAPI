using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Devices.Geolocation;

namespace WebAPI
{
    class LocationManager
    {
        public async static Task<Geoposition> GetPosition()
        {
            var accessStatus = await Geolocator.RequestAccessAsync();
            if (accessStatus != GeolocationAccessStatus.Allowed)
            {
                throw new Exception();
            }

            //  Ninguna precisión específica requerida
            var geolocator = new Geolocator { DesiredAccuracyInMeters = 0 };

            //  Posición real actual
            var position = await geolocator.GetGeopositionAsync();

            return position;
        }
    }
}
