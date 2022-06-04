using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBetterLimited.Models
{
    internal class AppointmentInfo
    {
        private DateTime Date;
        private int Session;

        public AppointmentInfo(DateTime date, int session)
        {
            Date = date;
            Session = session;
        }
    }
}
