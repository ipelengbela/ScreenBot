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
            
 
            return data = String.Format("this is what is going to be displayed :\n{0} \nbased on generation",TextGen.ChosenWord);

        }
    }
        
}

