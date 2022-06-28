namespace TheBetterLimited_Server.Data.Entity
{
    [Table("SalesOrderItem")]
    [PrimaryKey("Id" , "_salesOrderId" , "_supplierGoodsStockId")]
    public class SalesOrderItem
    {
        [Key]
        [MaxLength(10)]
        public string Id { get; set; }

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
        public string? _bookingOrderId { get; set; }

        [ForeignKey("_bookingOrderId")]
        public virtual BookingOrder? BookingOrder { get; set; }

        // seafoods price
        public double Price { get; set; }

        public virtual List<SalesOrderItem_Appointment>? SaleOrderItem_Appointment { get; set; }

    }
}