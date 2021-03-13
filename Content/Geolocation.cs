using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitterTrands.Content
{
    class Geolocation
    {
        private double latitud;

        private double longitude;
        public double Latitud
        {
            get
            {
                return latitud;
            }

            set
            {
                latitud = value;
            }
        }
        public double Longitude
        {
            get
            {
                return longitude;
            }
            set
            {
                longitude = value;
            }
        }

    }
}
