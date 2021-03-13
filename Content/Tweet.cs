using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitterTrands.Content
{
    class Tweet
    {
        private Geolocation geolocation;
        private string content;

        private float rating;
        public Geolocation Geolocation
        {
            get
            {
                return geolocation;
            }
            set
            {
                geolocation = value;
            }
        }
        public string Content
        {
            get
            {
                return content;
            }
            set
            {
                content = value;
            }
        }
        public float Rating
        {
            get
            {
                return rating;
            }

            set
            {
                rating = value;
            }
        }
    }
}
