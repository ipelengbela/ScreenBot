using System;
using OpenQA.Selenium;


namespace screen_crawler
{
    interface IBotNeeds
    {
        IWebDriver StartFF(string Url);
        IWebDriver StartIE(string Url);
        IWebDriver StartChrome(string Url);
    }
}
