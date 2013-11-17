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

        private void runAutomation_btn_Click(object sender, RoutedEventArgs e)
        {
            IWebDriver startSearch;
            string uName = userName_txt.Text;
            string uPass = pass_txt.Text;
            //start dll  web driver from open QA

           
               
                startSearch = BBotUtility.StartBrowser(setURL);
                BStartBot.RunApp(startSearch, uName, uPass, Dervalue);
           
           
            
            
        }

        private void _Rdo_Checked(object sender, RoutedEventArgs e)
        {
            BBotChecker.SelectWebAddress(sender);
            setURL = BBotChecker.SetURL;
            Dervalue = BBotChecker.Dervalue;

            
          
        }
        public string setURL;
        public int Dervalue;

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
