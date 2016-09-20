using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Web.Http;

namespace OnePress
{
    public class OnePressClient
    {
        public Uri url { get; set; }

        public OnePressClient(string domain, string customPath = "/wp-json/wp/v2/")
        {
            url = Extensions.ConvertStringToUri(domain + customPath);
        }

        public async Task<string> GetResponseAsString(OnePressMethod method)
        {
            var call_uri = url.AbsoluteUri;
            var uri = Extensions.ConvertStringToUri(call_uri);

            return await GetAsString(uri);
        }

        private async Task<string> GetAsString(Uri uri)
        {
            HttpClient client = new HttpClient();
            var response = await client.GetStringAsync(uri);

            return response;
        }
    }
}
