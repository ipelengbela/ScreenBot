using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
namespace screen_crawler
{
    class BBotUtility : BrowserbotCore
    {
        public static IWebDriver StartBrowser(string url)
        { IWebDriver rs;
            BBotUtility runMe = new BBotUtility();
           rs = runMe.StartFF(url);
           return rs;

        }
    }
}
