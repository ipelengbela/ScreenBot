using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using screen_crawler.BSocial;

namespace screen_crawler.BReader
{
    class TextLooper
        
    {
        private int maxChar = 140;
        
        internal string Go()
        {
            string data = "";
            bool valu = true;
            do
            {
              valu =  SelectWord.GetShortText();
            }
            while (maxChar > TextGen.ChosenWord.Length && valu);
           string test = TwitSpecial();

            return data = String.Format("Twitter display :\n{0}\ncount:{1}",TextGen.TwitSpecial, test);

        }

        /// <summary>
        /// needed to shorten string length just for twitter 140 character limit
        /// </summary>
        private string TwitSpecial()
        {
            string twittershort="";
            if (TextGen.ChosenWord.Length > maxChar)
            {
                 twittershort = TextGen.ChosenWord;

                TextGen.TwitSpecial = twittershort.Remove(140);
                twittershort = TextGen.TwitSpecial.Length.ToString();
                
            }
            return twittershort;
        }
    }
        
}

