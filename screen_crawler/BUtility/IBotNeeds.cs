using System;
using OpenQA.Selenium;
using screen_crawler.BSocial;


namespace screen_crawler.BUtility
{
    interface IBotNeeds
    {
        IWebDriver StartFF(string Url);
        IWebDriver StartIE(string Url);
        IWebDriver StartChrome(string Url);
    }
}
