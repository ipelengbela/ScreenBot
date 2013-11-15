﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using screen_crawler.BSocial;

namespace screen_crawler.BUtility
{
    class BBotUtility : BrowserbotCore
    {
        //public static IWebDriver StartBrowser(string url, int whatBrowser) { }
        public static IWebDriver StartBrowser(string url)
        { IWebDriver rs;
            BBotUtility runMe = new BBotUtility();
           rs = runMe.StartFF(url);
           return rs;

        }

        public static IWebDriver LogMeIn(IWebDriver startSearch,string uName, string uPass, int derValue)
        {
            IWebElement findme;
            switch (derValue)
            {
                case 1: // lkdn
            findme = startSearch.FindElement(By.Name("session_key"));
            findme.SendKeys(uName);
            findme = startSearch.FindElement(By.Name("session_password"));
            findme.SendKeys(uPass);
            findme = startSearch.FindElement(By.Name("signin"));
            findme.Click();
            return startSearch;
               case 2: // gplus
            findme = startSearch.FindElement(By.Name("Email"));
            findme.SendKeys(uName);
            findme = startSearch.FindElement(By.Name("Passwd"));
            findme.SendKeys(uPass);
            findme = startSearch.FindElement(By.Name("PersistentCookie"));
            findme.Click();
            findme = startSearch.FindElement(By.Name("signIn"));
            findme.Click();
            return startSearch;
                case 3: //facbook
            findme = startSearch.FindElement(By.Id("email"));
            findme.SendKeys(uName);
            findme = startSearch.FindElement(By.Id("pass"));
            findme.SendKeys(uPass);
            findme = startSearch.FindElement(By.XPath("//*[@id='u_0_e']"));
            findme.Click();
            return startSearch;
                case 4: //twit
            return startSearch;
                default: return startSearch;
                
            }
          //  return findme = (IWebElement)startSearch;
        }
    }
}