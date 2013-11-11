using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;


namespace screen_crawler
{
   abstract class BrowserbotCore : IBotNeeds
    {
       /// <summary>
       /// used to start mozilla FireFox
       /// </summary>
       /// <param name="Url">site url</param>
       /// <returns></returns>
       /// 
       public IWebDriver StartFF(string Url)
       {
           IWebDriver startSearch = new FirefoxDriver();
           startSearch.Navigate().GoToUrl(Url);
           //needed for slow firefox startup
           Thread.Sleep(5000);
           return startSearch;
       }

       /// <summary>
       /// used to start internet explorer
       /// </summary>
       /// <param name="Url"></param>
       /// <returns></returns>
       public IWebDriver StartIE(string Url)
       {
           throw new NotImplementedException("not implemented");
       }

       /// <summary>
       /// used to start chrome web browser
       /// </summary>
       /// <param name="Url"></param>
       /// <returns></returns>
       public IWebDriver StartChrome(string Url)
       {
           throw new NotImplementedException("not implemented");
       }
    }
}
