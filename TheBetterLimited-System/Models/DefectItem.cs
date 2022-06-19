using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBetterLimited.Models
{
    internal class DefectItem
    {
        public string _salesOrderId { get; set; }
        public string _supplierGoodsStockId { get; set; }
        public int handleStatus { get; set; }
        public string remark { get; set; }
        public int qty { get; set; }
        public CustomerInfo customer { get; set; }
    }
}
