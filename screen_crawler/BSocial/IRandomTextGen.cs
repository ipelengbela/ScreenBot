using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using screen_crawler.BUtility;

namespace screen_crawler.BSocial
{
    interface IRandomTextGen
    {
        string RandomDay();
        string DayOfWeek(string todaysDate);
    }
}
