﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Facebook.Client;

namespace FaceBookApp.Pages
{
    public partial class FacebookLogin : PhoneApplicationPage
    {
        private FacebookSession session;
        public FacebookLogin()
        {
            InitializeComponent();
            this.Loaded += FacebookLoginPage_Loaded;
        }

        async private void FacebookLoginPage_Loaded(object sender, RoutedEventArgs e)
        {
            if (!App.isAuthenticated)
            {
                App.isAuthenticated = true;
                await Authenticate();
            }
        }

        async private System.Threading.Tasks.Task Authenticate()
        {
            string message = String.Empty;
            try
            {
                session = await App.FacebookSessionClient.LoginAsync("user_about_me,read_stream");
                App.AccessToken = session.AccessToken;
                App.FacebookId = session.FacebookId;

                Dispatcher.BeginInvoke(() => NavigationService.Navigate(new Uri("/Pages/LandingPage.xaml", UriKind.Relative)));
            }
            catch (InvalidOperationException e)
            {
                message = "Login failed! Exception details: " + e.Message;
                MessageBox.Show(message);
            }
        }
    }
}