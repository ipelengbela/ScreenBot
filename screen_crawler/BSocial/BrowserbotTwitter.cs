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
        /// <summary>
        /// looks for dom objects to comment on twitter
        /// </summary>
        /// <param name="startSearch">Dom</param>
        /// <param name="uName">name</param>
        /// <param name="uPass">pass</param>
        /// <param name="derValue">bbot utility value/login value</param>
        internal static void Run(OpenQA.Selenium.IWebDriver startSearch, string uName, string uPass, int derValue)
        {
            IWebDriver startDerSeach = BBotUtility.LogMeIn(startSearch, uName, uPass, derValue);
            IWebElement findDerEle;
            startDerSeach.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10.0));
            findDerEle = startDerSeach.FindElement(By.XPath("//div[@id='tweet-box-mini-home-profile']"));
            findDerEle.Click();
            findDerEle.SendKeys("er mer gerd");
            startDerSeach.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10.0));
            findDerEle = startDerSeach.FindElement(By.XPath("//button[@class='btn primary-btn tweet-action js-tweet-btn']"));
            findDerEle.Click();
        }
    }
}
