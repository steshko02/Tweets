using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitterTrands.Content
{
    class State
    {
        private StateTypes name;
        private float rating;
        private List<Tweet> tweets = new List<Tweet>();
        private List<Geolocation> borderPoints = new List<Geolocation>(); 
    }
}
