using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using screen_crawler.BUtility;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace screen_crawler.BSocial
{
    class BrowserbotTwitter : TextGen
    {
        internal static void Run(OpenQA.Selenium.IWebDriver startSearch, string uName, string uPass, int derValue)
        {
            IWebDriver startDerSeach = BBotUtility.LogMeIn(startSearch, uName, uPass, derValue);
            IWebElement findDerEle;
            startDerSeach.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10.0));
        }
    }
}
