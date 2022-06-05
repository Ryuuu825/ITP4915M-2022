﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBetterLimited.Models
{
    internal class OrderItem
    {
        private string supplierGoodsStockId;
        private string name;
        private double price;
        private int stock;
        private bool needDelivery;
        private bool isDisplay;
        private bool needBooking;
        private int quantity;
        private string remark;
        public OrderItem()
        {
            this.supplierGoodsStockId = "0";
            this.stock = 0;
            this.name = "";
            this.price = 0.0;
            this.quantity = 1;
            this.needDelivery = false;
            this.isDisplay = false;
            this.needBooking = false;
            this.remark = String.Empty;
        }

        public string SupplierGoodsStockId { get => supplierGoodsStockId; set => supplierGoodsStockId = value; }
        public string Name { get => name; set => name = value; }
        public double Price { get => price; set => price = value; }
        public int Stock { get => stock; set => stock = value; }
        public bool NeedDelivery { get => needDelivery; set => needDelivery = value; }
        public bool IsDisplay { get => isDisplay; set => isDisplay = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public string Remark { get => remark; set => remark = value; }
        public bool NeedBooking { get => needBooking; set => needBooking = value; }
    }
}
