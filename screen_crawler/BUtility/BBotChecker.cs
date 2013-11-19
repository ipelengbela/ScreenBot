using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using screen_crawler.BSocial;

namespace screen_crawler.BUtility
{
    class BBotChecker : BrowserbotCore
    {
     
        internal static void SelectWebAddress(object sender)
        {

            System.Windows.Controls.RadioButton rdo = sender as System.Windows.Controls.RadioButton;
            switch (rdo.Name)
            {
                case "lkdn_Rdo":
                    SetURL = "https://www.linkedin.com/uas/login";
                    Dervalue = 1;
                    break;
                case "gPlus_Rdo":
                    SetURL = "https://plus.google.com/";
                    Dervalue = 2;
                    break;
                case "facBook_Rdo":
                    SetURL = "https://facebook.com/";
                    Dervalue = 3;
                    break;
                case "Twit_Rdo":
                    SetURL = "https://twitter.com/";
                    Dervalue = 4;
                    break;
                default:
                    Dervalue = 5;
                    SetURL = "http://bing.com/";
                    break;

            }
        }
        // may delete
        internal static object SetRadioName(int socialRun)
        { System.Windows.Controls.RadioButton rdo = new System.Windows.Controls.RadioButton();
           
            switch(socialRun)
            {
                case 1:
                    rdo.Name ="lkdn_Rdo";
                    return rdo;
                case 2:
                    rdo.Name ="gPlus_Rdo";
                    return rdo;
                case 3: 
                    rdo.Name ="facBook_Rdo";
                    return rdo;
                case 4:
                    rdo.Name ="Twit_Rdo";
                    return rdo;
                default:
                    return rdo;
            }
            
            
        }


        public static string SetURL {get; set;}
        public static int Dervalue {get; set;}


       
    }
}