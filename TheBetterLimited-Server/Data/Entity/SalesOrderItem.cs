namespace TheBetterLimited_Server.Data.Entity
{
    [Table("SalesOrderItem")]
    public class SalesOrderItem
    {
        [MaxLength(10)]
        [Column(TypeName = "char(10)")]
        public string _salesOrderId { get; set; }

        [ForeignKey("_salesOrderId")]
        public virtual SalesOrder SalesOrder { get; set; }

        public string _supplierGoodsStockId { get; set; }

        [ForeignKey("_supplierGoodsStockId")]
        public virtual Supplier_Goods_Stock SupplierGoodsStock { get; set; }

        [Column(TypeName = "TINYINT")]
        [Range(0, 999)]
        public int Quantity { get; set; }

        [MaxLength(10)]
        [Column(TypeName = "char(10)")]
        public string? _appointmentId { get; set; }

        [ForeignKey("_appointmentId")]
        public virtual Appointment? Appointment { get; set; }

        [MaxLength(10)]
        [Column(TypeName = "char(10)")]
        public string? _bookingOrderId { get; set; }

        [ForeignKey("_bookingOrderId")]
        public virtual BookingOrder? BookingOrder { get; set; }

        // seafoods price
            public int Price { get; set; }

    }
}