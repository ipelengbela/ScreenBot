using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
namespace screen_crawler
{
    class BrowserbotGooglePlus : TextGen
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
            findMe = startSearch.FindElement(By.XPath("/html/body/div[2]/div[3]/div[2]/div[4]/div/div/div[2]/div/div[2]/div[2]/div/div/div/div/div/div/div[2]"));
            findMe.Click();
            Thread.Sleep(2000);
            //findMe = startSearch.FindElement(By.XPath("//*[@id=':2q.f']"));
            findMe = startSearch.FindElement(By.XPath("/html/body/div[2]/div[3]/div[2]/div[4]/div/div/div[2]/div/div[2]/div/div/div[2]/div/div[7]/div[2]/div[2]/div/div[2]/div[2]"));
            findMe.SendKeys("this is hard");
            Thread.Sleep(2000);
            // this works but after the first time your on google plus, its no longer needed
            //findMe = startSearch.FindElement(By.Id("sbdp"));
           // findMe.Click();
            // findMe = startSearch.FindElement(By.PartialLinkText("Public"));
           // findMe.Click();
            //Thread.Sleep(2000);
            //use xpath
            findMe = startSearch.FindElement(By.XPath("/html/body/div[2]/div[3]/div[2]/div[4]/div/div/div[2]/div/div[2]/div/div/div[2]/div[2]/table/tbody/tr/td/div"));
            findMe.Click();
        }

       
    }
}
