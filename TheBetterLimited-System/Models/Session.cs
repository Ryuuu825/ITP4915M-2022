using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBetterLimited.Models
{
    internal class Session
    {
        private DateTime EndTime;
        private DateTime Date;
        private DateTime StartTime;
        private string ID;
        private int NumOfAppointments;
        private string _departmentId;

        public Session(DateTime endTime, DateTime date, DateTime startTime, string iD, int numOfAppointments, string departmentId)
        {
            EndTime = endTime;
            Date = date;
            StartTime = startTime;
            ID = iD;
            NumOfAppointments = numOfAppointments;
            _departmentId = departmentId;
        }

        public DateTime EndTime1 { get => EndTime; set => EndTime = value; }
        public DateTime Date1 { get => Date; set => Date = value; }
        public DateTime StartTime1 { get => StartTime; set => StartTime = value; }
        public string ID1 { get => ID; set => ID = value; }
        public int NumOfAppointments1 { get => NumOfAppointments; set => NumOfAppointments = value; }
        public string DepartmentId { get => _departmentId; set => _departmentId = value; }
    }
}
