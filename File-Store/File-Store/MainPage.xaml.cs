using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using File_Store.Resources;
using System.Diagnostics;
using System.Text;
using System.IO.IsolatedStorage;
using File_Store.Repository;
using System.Net.Http;
using File_Store.Models;

namespace File_Store
{
    public partial class MainPage : PhoneApplicationPage
    {

        private IsolatedStorageSettings settings;
        private AccountRepository acc;

        private User user;
        

        // Constructor
        public  MainPage()
        {
            InitializeComponent();
            acc = new AccountRepository();
            user = new User();
            this.DataContext = user;
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            user.username = "Paul";
            main.Text = "loading...";
            var token = await acc.getToken();
            main.Text = token;
       
        }

        async protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            var token = await acc.getToken();
            user.auth = token;



        }

    }
}