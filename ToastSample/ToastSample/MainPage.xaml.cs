using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Newtonsoft.Json;
using ToastSample.Resources;

namespace ToastSample
{

    public class Person
    {
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string company_name { get; set; }
    }
    public partial class MainPage : PhoneApplicationPage
    {

        List<Person> _viewModel;
        // Constructor
        public MainPage()
        {
            InitializeComponent();
        }




        protected async override void OnNavigatedTo(NavigationEventArgs e)
        {
            //fetch all clients from mongodb rest api

            const string apikey = "4eaa9329e4b079327de623c7";
            const string baseurl = "https://api.mongolab.com/api/1/databases/sampledatapeople/collections";
            using (var client = new HttpClient())
            {
                var uri = String.Format("{0}{1}?apiKey={2}", baseurl, "/people", apikey);
                var response = await client.GetStringAsync(new Uri(uri));
                if (response != null)
                {

                    _viewModel = JsonConvert.DeserializeObject<List<Person>>(response);
                    LongListSelector.ItemsSource = _viewModel;
                    progressBar.Visibility = Visibility.Collapsed;
                    var toast = new ShellToast {Title = "testing", Content = "Testing with Content!"};
                    
                    toast.Show();
                }
            }
            base.OnNavigatedTo(e);
        }
    }
}