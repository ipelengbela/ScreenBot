using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;
using screen_crawler.BUtility;

namespace screen_crawler.BSocial
{
    class BrowserbotFacebook : TextGen
    {
        //may need to change this method to generic

        /// <summary>
        /// searches DOM  in order to comment 
        /// </summary>
        /// <param name="startSearch">iweb driver that contains ff/DOM</param>
        /// <param name="uName">name</param>
        /// <param name="uPass">pass</param>
        /// <param name="derValue">value for switch/case to log in</param>
        internal static void Run(OpenQA.Selenium.IWebDriver startSearch, string uName, string uPass, int derValue)
        {
            IWebDriver startDerSearch = BBotUtility.LogMeIn(startSearch, uName, uPass, derValue);
            
            IWebElement findEle;

         
            startDerSearch.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(5.0));
            System.Threading.Thread.Sleep(3000);
            // changed this to a config file since this may change 
            startDerSearch.Navigate().GoToUrl("https://www.facebook.com/?sk=nf");
            findEle = startDerSearch.FindElement(By.XPath("//textarea[@name='xhpc_message']"));
            startDerSearch.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10.0));
           
            findEle.Click();
            findEle = startDerSearch.FindElement(By.XPath("//textarea[@name='xhpc_message_text']"));
            System.Threading.Thread.Sleep(2000);
            findEle.SendKeys(ChosenWord);
            findEle = startDerSearch.FindElement(By.XPath("//li/button[@type='submit']"));
            findEle.Click();
        }
    }
}
