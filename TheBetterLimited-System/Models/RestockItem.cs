using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBetterLimited.Models
{
    internal class RestockItem
    {
        public RestockItem(string supplierGoodsStockId, int quantity)
        {
            _supplierGoodsStockId = supplierGoodsStockId;
            this.quantity = quantity;
        }

        public string _supplierGoodsStockId { get; set; }
        public int quantity { get; set;}

    }
}
