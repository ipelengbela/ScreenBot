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
      

        internal static void Run(IWebDriver startSearch, string uName, string uPass)
        {
            IWebElement findme = startSearch.FindElement(By.Name("session_key"));
            findme.SendKeys(uName);
            findme = startSearch.FindElement(By.Name("session_password"));
            findme.SendKeys(uPass);
            findme = startSearch.FindElement(By.Name("signin"));
            findme.Click();
            //
            Thread.Sleep(10000);
            findme = startSearch.FindElement(By.Name("postText"));
            findme.Click();
            findme.SendKeys("er mer gerd");
            findme = startSearch.FindElement(By.Id("share-submit"));
            findme.Click();
        }
    }
}
