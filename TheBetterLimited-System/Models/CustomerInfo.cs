using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBetterLimited.Models
{
    internal class CustomerInfo
    {
        private string id;
        private string name;
        private string phone;
        private string address;

        public CustomerInfo(string cusName, string cusPhone, string cusAddress)
        {
            id = new Random().Next(1000).ToString();
            this.name = cusName;
            this.phone = cusPhone;
            this.address = cusAddress;
        }

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Address { get => address; set => address = value; }
    }
}
