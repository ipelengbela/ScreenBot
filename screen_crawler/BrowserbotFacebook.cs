using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;

namespace screen_crawler
{
    class BrowserbotFacebook : TextGen
    {
        //may need to change this method to generic
        internal static void Run(OpenQA.Selenium.IWebDriver startSearch, string uName, string uPass, int derValue)
        {
            IWebDriver startDerSearch = BBotUtility.LogMeIn(startSearch, uName, uPass, derValue);
            
            IWebElement findEle;

         
            startDerSearch.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(5.0));
            
            startDerSearch.Navigate().GoToUrl("https://www.facebook.com/?sk=nf");
            findEle = startDerSearch.FindElement(By.XPath("//textarea[@name='xhpc_message']"));
            
            findEle.Click();
            findEle = startDerSearch.FindElement(By.XPath("//textarea[@name='xhpc_message_text']"));
            findEle.SendKeys("lol");
            findEle = startDerSearch.FindElement(By.XPath("//li/button[@type='submit']"));
            findEle.Click();
        }
    }
}
