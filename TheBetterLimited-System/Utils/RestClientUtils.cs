using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBetterLimited.Utils
{
    public class RestClientUtils
    {
        public static readonly RestClient client = new RestClient("http://127.0.0.1:5233");
    }
}
