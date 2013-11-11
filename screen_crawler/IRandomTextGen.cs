using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace screen_crawler
{
    interface IRandomTextGen
    {
        string RandomDay();
        string DayOfWeek(string todaysDate);
    }
}
