using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBetterLimited.Models
{
    internal class AppointmentInfo
    {
        private string sessionId;
        private string _departmentId;

        public AppointmentInfo(string sessionId, string departmentId)
        {
            this.sessionId = sessionId;
            _departmentId = departmentId;
        }
    }
}
