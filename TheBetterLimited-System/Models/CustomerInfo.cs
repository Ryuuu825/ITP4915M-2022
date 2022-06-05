using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBetterLimited.Models
{
    internal class CustomerInfo
    {
        private string _id;
        private string cusName;
        private string cusPhone;
        private string cusAddress;

        public CustomerInfo(string cusName, string cusPhone, string cusAddress)
        {
            _id = new Random().Next(1000).ToString();
            this.cusName = cusName;
            this.cusPhone = cusPhone;
            this.cusAddress = cusAddress;
        }
    }
}
