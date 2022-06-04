using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBetterLimited.Models
{
    internal class AppointmentInfo
    {
        private DateTime deliveryDate;
        private int deliverySession;
        private DateTime installDate;
        private int installSession;

        public AppointmentInfo(DateTime deliveryDate, int deliverySession, DateTime installDate, int installSession)
        {
            this.deliveryDate = deliveryDate;
            this.deliverySession = deliverySession;
            this.installDate = installDate;
            this.installSession = installSession;
        }
    }
}
