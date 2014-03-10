using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using HttpExample.Resources;

namespace HttpExample
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();

        }

        protected async override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            string normReqUrl;
              string normReqParams;
                OAuthBase oAuth = new OAuthBase();

                string nonce = oAuth.GenerateNonce();
                string timeStamp = oAuth.GenerateTimeStamp();


            Uri uri =
                new Uri("https://api.test.worapay.com/access/public?device_id=" +
                        HttpUtility.UrlEncode("0123456789123456").ToUpper() + "&phone_number=" +
                        HttpUtility.UrlEncode("0825532732").ToUpper() + "&version=1");

               string sig = oAuth.GenerateSignature(uri, "R59qhvU27TgcDctQd7", "6duxju5QFM2ETgt2AaJvJ4kdTN4ktnFw",
                    string.Empty, string.Empty,
                    "POST", timeStamp, nonce,
                    OAuthBase.SignatureTypes.HMACSHA1, out normReqUrl, out normReqParams);

              sig = HttpUtility.UrlEncode(sig);

            string data = normReqParams + "&oauth_signature=" + sig;

           var req = (HttpWebRequest)WebRequest.Create(normReqUrl);

            req.Method = "POST";
            req.ContentType = "application/x-www-form-urlencoded";

            byte[] reqData = Encoding.UTF8.GetBytes(data);
            //byte[] reqData = Encoding.UTF8.GetBytes("");
            req.ContentLength = reqData.Length;
            
            var handler = new HttpClientHandler { Credentials = new  NetworkCredential("MyUSER", "MyPASS")};
            var client = new HttpClient(handler);

            client.DefaultRequestHeaders.Add("ContentType", "application/x-www-form-urlencoded");
            
            var response = await client.PostAsync(new Uri(normReqUrl), new ByteArrayContent(reqData));


        }
    }
}