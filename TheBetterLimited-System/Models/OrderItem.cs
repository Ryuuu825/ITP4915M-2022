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
        private double price;
        private int quantity;
        private string remark;

        public OrderItem()
        {
            this.id = 0;
            this.name = "";
            this.price = 0.0;
            this.quantity = 0;
            this.remark = String.Empty;
        }

        public OrderItem(int id, string name, double price, int quantity, string remark)
        {
            this.id = id;
            this.name = name;
            this.price = price;
            this.quantity = quantity;
            this.remark = remark;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public double Price { get => price; set => price = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public string Remark { get => remark; set => remark = value; }
    }
}
