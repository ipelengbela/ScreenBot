using System;
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
       /// <summary>
       /// starts the web browser for the first time
       /// </summary>
       /// <param name="url">the url where it points to</param>
       /// <returns></returns>
        public static IWebDriver StartBrowser(string url)
        { IWebDriver rs;
            BBotUtility runMe = new BBotUtility();
           rs = runMe.StartFF(url);
           return rs;

        }
        /// <summary>
        /// logs you into the website
        /// </summary>
        /// <param name="startSearch">contains the web page</param>
        /// <param name="uName">user name</param>
        /// <param name="uPass">password</param>
        /// <param name="derValue">value to select login site param</param>
        /// <returns></returns>
        public static IWebDriver LogMeIn(IWebDriver startSearch,string uName, string uPass, int derValue)
        {
            /*
            WebDriverWait wait = new WebDriverWait(startSearch, TimeSpan.FromSeconds(10));
        IWebElement myDynamicElement = wait.Until<IWebElement>((d) =>
                  {
        return d.FindElement(By.Id("someDynamicElement"));
                 });
             */
            IWebElement findme;
            switch (derValue)
            {
                case 1: // lkdn
                    startSearch.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(30));
                    System.Threading.Thread.Sleep(10000);
                    findme = startSearch.FindElement(By.Name("session_key"));
                    findme.SendKeys(uName);
                    findme = startSearch.FindElement(By.Name("session_password"));
                    findme.SendKeys(uPass);
                    System.Threading.Thread.Sleep(1000);
                    findme = startSearch.FindElement(By.Name("signin"));
                    findme.Click();
                    return startSearch;
               case 2: // gplus
                    findme = startSearch.FindElement(By.Name("Email"));
                    findme.SendKeys(uName);
                    findme = startSearch.FindElement(By.Name("Passwd"));
                    findme.SendKeys(uPass);
                    System.Threading.Thread.Sleep(5000);
                    findme = startSearch.FindElement(By.Name("PersistentCookie"));
                    findme.Click();
                    System.Threading.Thread.Sleep(1000);
                    findme = startSearch.FindElement(By.Name("signIn"));
                    findme.Click();
                    return startSearch;
                case 3: //facbook
                    findme = startSearch.FindElement(By.Id("email"));
                    findme.SendKeys(uName);
                    System.Threading.Thread.Sleep(1000);
                    findme = startSearch.FindElement(By.Id("pass"));
                    findme.SendKeys(uPass);
                    System.Threading.Thread.Sleep(1000);
                    findme = startSearch.FindElement(By.XPath("//*[@id='u_0_e']"));
                    findme.Click();
                    return startSearch;
                case 4: //twit
                    //for twitter you need to click on input first since it is dynamic
                    findme = startSearch.FindElement(By.XPath("//input[@id='signin-email']"));
                    findme.Click();
                    findme.SendKeys(uName);
                    findme = startSearch.FindElement(By.XPath("//input[@id='signin-password']"));
                    System.Threading.Thread.Sleep(1000);
                    findme.Click();
                    findme.SendKeys(uPass);
                    System.Threading.Thread.Sleep(1000);
                    findme = startSearch.FindElement(By.XPath("//button[@class='submit btn primary-btn flex-table-btn js-submit']"));
                    findme.Click();
                    return startSearch;
                default: 
                    return startSearch;
                
            }
        }
    }
}
