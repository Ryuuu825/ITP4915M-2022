using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheBetterLimited_System.Controller;

namespace TheBetterLimited.Controller
{
    internal class POSController : ControllerBase
    {
        public POSController(string ControllerName) : base(ControllerName)
        {
            this.ControllerName = ControllerName;
        }
    }
}
