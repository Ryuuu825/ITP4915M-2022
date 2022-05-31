namespace TheBetterLimited_Server.Data.Entity
{
    [Table("PurchaseOrder_Supplier_Goods")]
    public class PurchaseOrder_Supplier_Goods
    {
        [MaxLength(10)]
        [Column(TypeName = "char(10)")]
        public string _purchaseOrderId { get; set;}

        [ForeignKey("_purchaseOrderId")]
        public virtual PurchaseOrder PurchaseOrder { get; set; }

        [MaxLength(9)]
        [Column(TypeName = "char(9)")]
        public string _supplierGoodsId { get; set;}

        [ForeignKey("_supplierGoodsId")]
        public virtual Supplier_Goods Supplier_Goods { get; set; }

        [Column(TypeName = "SMALLINT")]
        public uint Quantity { get; set; }
    }
}