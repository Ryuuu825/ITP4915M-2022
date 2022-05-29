using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBetterLimited.Models
{
    internal class OrderItem
    {
        private int id;
        private string name;
        private string price;
        private int quantity;
        private string remark;

        public OrderItem(int id, string name, string price, int quantity, string remark)
        {
            this.id = id;
            this.name = name;
            this.price = price;
            this.quantity = quantity;
            this.remark = remark;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Price { get => price; set => price = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public string Remark { get => remark; set => remark = value; }
    }
}
