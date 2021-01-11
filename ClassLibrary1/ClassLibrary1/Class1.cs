using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;


namespace ClassLibrary1
{
    public class Class1
    {
        static HttpClient client = new HttpClient();

        public class AuctionLink
        {
            public string url { get; set; }
            public string lastModified { get; set; }
        }

        static async Task<AuctionLink> GetAuction(string path)
        {
            AuctionLink link = null;
            HttpResponseMessage response = await client.GetAsync(path);
            if (response.IsSuccessStatusCode)
            {
                link = await response.Content.ReadAsAsync<AuctionLink>();
            }
            return link;
        }
    }
}
