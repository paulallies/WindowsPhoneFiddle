using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace File_Store.Repository
{
    public class AccountRepository
    {

        public async Task<string> getToken()
        {
            HttpClient httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Add("X-Auth-User", "paul.allies@mweb.co.za");
            httpClient.DefaultRequestHeaders.Add("X-Auth-Key", "pass753");

            var response = await httpClient.GetAsync(new Uri("https://store-it.mweb.co.za/auth/v1.0/", UriKind.Absolute));

            var value = getHeaderValue(response.Headers, "X-Auth-Token");
            return value;

        }

        private string getHeaderValue(System.Net.Http.Headers.HttpResponseHeaders headers, string headername)
        {
            string result = "";

            foreach (var header in headers)
            {
                if (header.Key.Equals(headername))
                {
                    result = header.Value.FirstOrDefault();
                }
            }
            return result;
        }
    }
}
