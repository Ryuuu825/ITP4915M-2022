using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheBetterLimited.Models;
using TheBetterLimited_System.Controller;

namespace TheBetterLimited.Controller
{
    internal class RQController : ControllerBase
    {
        public RQController(string ControllerName) : base(ControllerName)
        {
            this.ControllerName = ControllerName;
        }

        public RestResponse UpdateStatus(string id, int status, string lang = "en")
        {
            var request = new RestRequest("/api/" + ControllerName + "/status/" + id, Method.Put)
                        .AddHeader("Language", lang)
                        .AddHeader("Authorization", string.Format("Bearer {0}", GlobalsData.currentUser["token"]))
                        .AddBody(status);
            return GetRestResponse(request);
        }
    }
}
