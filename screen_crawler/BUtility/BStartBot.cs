using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using screen_crawler.BSocial;

namespace screen_crawler.BUtility
{
    class BStartBot : BrowserbotCore
    {
        internal static void RunApp(OpenQA.Selenium.IWebDriver startSearch, string uName, string uPass, int Dervalue)
        {
            switch (Dervalue)
            {  // need to change to a generic method instead of this
                case 1:
                    BrowserbotLinkedin.Run(startSearch, uName, uPass, Dervalue);
                    break;
                case 2:
                    BrowserbotGooglePlus.Run(startSearch, uName, uPass, Dervalue);
                    break;
                case 3:
                    BrowserbotFacebook.Run(startSearch, uName, uPass, Dervalue);
                    break;
                case 4:
                    BrowserbotTwitter.Run(startSearch, uName, uPass, Dervalue);
                    break;
            }

        }
    }
}
