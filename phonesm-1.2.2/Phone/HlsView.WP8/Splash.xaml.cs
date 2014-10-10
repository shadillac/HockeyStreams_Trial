﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System.IO.IsolatedStorage;
using Microsoft.Phone.Tasks;

namespace HlsView
{
    public partial class Splash : PhoneApplicationPage
    {
        private IsolatedStorageSettings userSettings = IsolatedStorageSettings.ApplicationSettings;
        public Splash()
        {
            InitializeComponent();
        }

        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {
            System.Threading.Thread.Sleep(1000);

            try
            {
                int trialCount = (int)userSettings["TrialCount"];
                trialCount = trialCount + 1;
                userSettings["TrialCount"] = trialCount;
                if (trialCount.ToString().EndsWith("0"))
                {
                    MessageBoxResult result = MessageBox.Show("Thanks for using the trial version of Top Cheddar Hockey Streams.  Would you like to upgrade to the full version and remove all these ads?","Upgrade from Trial?",MessageBoxButton.OKCancel);
                    if (result == MessageBoxResult.OK)
                    {
                        WebBrowserTask webBrowserTask = new WebBrowserTask();
                        webBrowserTask.Uri = new Uri("http://www.windowsphone.com/s?appid=fe08e7c0-f504-4453-bb0d-2b3cb862452a");
                        webBrowserTask.Show();
                    }
                }
            }
            catch
            {
                try
                {
                    userSettings.Add("TrialCount", 1);
                }
                catch (ArgumentException)
                {
                    userSettings["TrialCount"] = 1;
                }
            }

            try
            {
                string authToken = (string)userSettings["Token"];
                NavigationService.Navigate(new Uri("/PivotMain.xaml",UriKind.Relative));
            }
            catch (KeyNotFoundException)
            {
                NavigationService.Navigate(new Uri("/Login.xaml",UriKind.Relative));
            }
        }
    }
}