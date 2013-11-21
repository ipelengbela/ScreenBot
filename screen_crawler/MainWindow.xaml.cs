using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
//using OpenQA.Selenium.IE;// must download iedriver server dll from google code in order for this dll to work
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System.Threading;
//using OpenQA.Selenium.Chrome; // must download chromedriver download from google api in order for this dll to work
using screen_crawler.BUtility;
using Microsoft.Win32;

namespace screen_crawler
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// starts the automation of social media based on what the value is 
        /// </summary>
        /// <param name="sender">the button</param>
        /// <param name="e">the event of button</param>
        private void runAutomation_btn_Click(object sender, RoutedEventArgs e)
        {
            IWebDriver startSearch;
            
            //start dll  web driver from open QA

           
               
                startSearch = BBotUtility.StartBrowser(setURL);
                if (Dervalue != 5)
                {
                    string uName = userName_txt.Text;
                    string uPass = pass_txt.Text;
                    BStartBot.RunApp(startSearch, uName, uPass, Dervalue); 
                }
                else
                {

                    //BBotChecker setValues = new BBotChecker();
                    BBotChecker.Passwords = new[] { password1.Text, password2.Text, password3.Text, password4.Text };
                    BBotChecker.Usernames = new[] { userName1.Text, userName2.Text, userName3.Text, userName4.Text };
                   
                    BStartBot.RunAllSocialMediaSites(Dervalue, startSearch);
                }
           
            
            
        }
        /// <summary>
        /// depending on what is checked it sets the uri for its run
        /// </summary>
        /// <param name="sender">the radio button</param>
        /// <param name="e">radio button event</param>
        private void _Rdo_Checked(object sender, RoutedEventArgs e)
        {
            BBotChecker.SelectWebAddress(sender);
            setURL = BBotChecker.SetURL;
            Dervalue = BBotChecker.Dervalue;

            //hide txtbox show others
            if (Dervalue == 5)
            {
                Canvas_Single.Visibility = Visibility.Hidden;
                multisocialCanvas.Visibility = Visibility.Visible;
             }
            else
            {
                Canvas_Single.Visibility = Visibility.Visible;
                multisocialCanvas.Visibility = Visibility.Hidden;
            }
            
          
        }
        public string setURL;
        public int Dervalue;

        /// <summary>
        /// selects csv file which is going to be used for random string generation based on text file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, RoutedEventArgs e)
        {

            OpenFileDialog dg = new OpenFileDialog();
            dg.ShowDialog();
            ReadFile.FilePath = dg.FileName;
            string r = ReadFile.ReadCSV();
            MessageBox.Show(r);
        }
    }
}
