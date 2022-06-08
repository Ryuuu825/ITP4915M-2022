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
    internal class AppointmentController : ControllerBase
    {
        public AppointmentController(string ControllerName) : base(ControllerName)
        {
            this.ControllerName = ControllerName;
        }

        public RestResponse GetAll(int month, int day, string limit = "0", string offset = "0", string lang = "en")
        {
            var request = new RestRequest("/api/" + ControllerName, Method.Get)
                        .AddQueryParameter("limit", limit)
                        .AddQueryParameter("offset", offset)
                        .AddQueryParameter("month", month)
                        .AddQueryParameter("day", day)
                        .AddHeader("Language", lang)
                        .AddHeader("Authorization", string.Format("Bearer {0}", GlobalsData.currentUser["token"]));
            return GetRestResponse(request);
        }
    }
}
