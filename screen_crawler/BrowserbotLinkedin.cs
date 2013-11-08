using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace screen_crawler
{
   class BrowserbotLinkedin: BrowserbotCore
    {
      
        internal static void Run()
        {
            IWebDriver startSearch = new FirefoxDriver();
            //navigate to site
            startSearch.Navigate().GoToUrl("https://www.linkedin.com/uas/login");
            //needed for slow firefox startup
            Thread.Sleep(5000);
            //find dom element 
            IWebElement findme = startSearch.FindElement(By.Name("session_key"));
            findme.SendKeys("serendipityok@gmx.us");
            findme = startSearch.FindElement(By.Name("session_password"));
            findme.SendKeys("1fatmonkey");
            findme = startSearch.FindElement(By.Name("signin"));
            findme.Click();
            //
            Thread.Sleep(2000);
            findme = startSearch.FindElement(By.Name("postText"));
            findme.Click();
            findme.SendKeys("er mer gerd");
            findme = startSearch.FindElement(By.Id("share-submit"));
            findme.Click();
        }


    }
}
