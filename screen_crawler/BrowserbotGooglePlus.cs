using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
namespace screen_crawler
{
    class BrowserbotGooglePlus : BrowserbotCore
    {
        internal static void Run(IWebDriver startSearch, string uName, string uPass)
        {
            IWebElement findMe = startSearch.FindElement(By.Name("Email"));
            findMe.SendKeys(uName);
            findMe = startSearch.FindElement(By.Name("Passwd"));
            findMe.SendKeys(uPass);
            findMe = startSearch.FindElement(By.Name("PersistentCookie"));
            findMe.Click();
            findMe = startSearch.FindElement(By.Name("signIn"));
            findMe.Click();
            Thread.Sleep(11000);
            //use xpath
            findMe = startSearch.FindElement(By.PartialLinkText("Share what's new..."));
            findMe.Click();
            Thread.Sleep(2000);
            findMe = startSearch.FindElement(By.Id(":3c.f"));
            findMe.SendKeys("hello google");
            Thread.Sleep(2000);
            findMe = startSearch.FindElement(By.Id("sbdp"));
            findMe.Click();
            //use xpath
            findMe = startSearch.FindElement(By.PartialLinkText("Public"));
            findMe.Click();
            Thread.Sleep(2000);
            //use xpath
            findMe = startSearch.FindElement(By.PartialLinkText("Share"));
            findMe.Click();
        }
    }
}
