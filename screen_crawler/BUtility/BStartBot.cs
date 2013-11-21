using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using screen_crawler.BSocial;

namespace screen_crawler.BUtility
{
    class BStartBot : BrowserbotCore
    {
        /// <summary>
        /// runs procedure to automate comment on social media based on selection
        /// </summary>
        /// <param name="startSearch"></param>
        /// <param name="uName">name</param>
        /// <param name="uPass">psswrd</param>
        /// <param name="Dervalue">selection value/ what site chosen</param>
        internal static void RunApp(OpenQA.Selenium.IWebDriver startSearch, string uName, string uPass, int Dervalue)
        {
            switch (Dervalue)
            {  // need to change to a generic method instead of this
                case 1:
                    BrowserbotLinkedin.Run(startSearch, uName, uPass, Dervalue);
                    break;
                case 2:
                    BrowserbotGooglePlus.Run(startSearch, uName, uPass, Dervalue);
                    break;
                case 3:
                    BrowserbotFacebook.Run(startSearch, uName, uPass, Dervalue);
                    break;
                case 4:
                    BrowserbotTwitter.Run(startSearch, uName, uPass, Dervalue);
                    break;
            }

        }

        /// <summary>
        /// runs all 4 social media sites by selecting website/navigating to and running Run app method
        /// </summary>
        /// <param name="Dervalue">the value of 5</param>
        /// <param name="startSearch">i web driver DOM of page</param>
        internal static void RunAllSocialMediaSites(int Dervalue, OpenQA.Selenium.IWebDriver startSearch)
        {
            //BBotChecker nr = new BBotChecker();
            string uName ="",  uPass ="";
            Dervalue -= 1 ;
            for (int socialRun = 1; Dervalue >= socialRun ; socialRun++)
            {
              //needed to set radio value that selectwebaddress depends on
                var mediaSite =  BBotChecker.SetRadioName(socialRun);
             // sets the url
                System.Threading.Thread.Sleep(10000);
                BBotChecker.SelectWebAddress(mediaSite);
                startSearch.Navigate().GoToUrl(BBotChecker.SetURL);

               uPass = BBotChecker.Passwords[socialRun -1];
               uName = BBotChecker.Usernames[socialRun -1 ];
               
               RunApp(startSearch, uName, uPass, socialRun);
            }
        }

       
    }
}
