using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBetterLimited.Utils
{
    public static class RestClientUtils
    {
        public static RestClient CreateClient(string url)
        {
            RestClient client = new RestClient(url);
            return client;
        }
    }
}
