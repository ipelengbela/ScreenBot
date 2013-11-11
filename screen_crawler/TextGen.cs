using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace screen_crawler 
{
   public class TextGen :IRandomTextGen
    {
        public string RandomDay()
        {
            throw new NotImplementedException();
        }

        public string DayOfWeek(string todaysDate)
        {
            throw new NotImplementedException();
        }

        public enum Day
        {
            Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
        }
    }
}
