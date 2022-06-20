using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBetterLimited.Models
{
    internal class PurchaseItem
    {
        public PurchaseItem(string goodsId, string name, int price, int quantity)
        {
            _goodsId = goodsId;
            this.price = price;
            this.goodsName = name;
            this.quantity = quantity;
        }

        public string _goodsId { get; set; }
        public int price { get; set; }
        public string goodsName { get; set; }
        public int quantity { get; set; }

    }
}
