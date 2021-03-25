using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwitterTrands.Content;

namespace TwitterTrands.Parsing
{
    class ParsingTweet
    {
        public static Tweet parsingString(string tweetString)
        {
            if(tweetString == null) // 
            {
                return null; // fix
            }
            Tweet tweet = new Tweet();

            int i = 1;
            while (tweetString[i] ==',')
            {

            }
            return tweet;
        }

        private static double receiveLocationValue()
        {


            return 0;
        }


    }
}
