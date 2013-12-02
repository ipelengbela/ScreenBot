using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using screen_crawler.BUtility;

namespace screen_crawler.BSocial
{
    class BrowserbotGooglePlus : TextGen
    {
        /// <summary>
        /// looks for DOM objects to comment on google plus
        /// </summary>
        /// <param name="startSearch">DOM/</param>
        /// <param name="uName">name</param>
        /// <param name="uPass">pass</param>
        /// <param name="derValue">what value to log in based on bbotutility</param>
        internal static void Run(IWebDriver startSearch, string uName, string uPass, int derValue)
        {
            IWebDriver startDerSearch = BBotUtility.LogMeIn(startSearch, uName, uPass, derValue);
           
            IWebElement findMe;
            startDerSearch.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10.0));
            
            findMe = startDerSearch.FindElement(By.XPath("//div[@class='pga']/div/div/div/div/div/div/div[@role='button']"));
          
            findMe.Click();
            Thread.Sleep(2000);
            //  findMe = startSearch.FindElement(By.XPath("//div[@guidedhelpid='sharbox_editor']/div[2]/div[@role='textbox']"));
            findMe = startDerSearch.FindElement(By.XPath("/html/body/div[2]/div[3]/div[2]/div[4]/div/div/div[2]/div/div[2]/div/div/div[2]/div/div[7]/div[2]/div[2]/div/div[2]/div[2]"));
            findMe.SendKeys(ChosenWord);
            Thread.Sleep(2000);
            
            // this works but after the first time your on google plus, its no longer needed
            //findMe = startSearch.FindElement(By.Id("sbdp"));
           // findMe.Click();
            // findMe = startSearch.FindElement(By.PartialLinkText("Public"));
           // findMe.Click();
            //Thread.Sleep(2000);
            //use xpath
            
            findMe = startDerSearch.FindElement(By.XPath("/html/body/div[2]/div[3]/div[2]/div[4]/div/div/div[2]/div/div[2]/div/div/div[2]/div[2]/table/tbody/tr/td/div"));
            findMe.Click();
        }

       
    }
}
