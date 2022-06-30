namespace TheBetterLimited_Server.Data.Entity
{
    [Table("RestockRequest_Supplier_Goods")]
    public class  RestockRequest_Supplier_Goods_Stock
    {
        [MaxLength(10)]
        [Column(TypeName = "char(10)")]
        public string _restockRequestId { get; set;}

        [ForeignKey("_restockRequestId")]
        public virtual RestockRequest RestockRequest { get; set; }

        [MaxLength(9)]
        [Column(TypeName = "char(9)")]
        public string _supplierGoodsStockId { get; set;}

        [ForeignKey("_supplierGoodsId")]
        public virtual Supplier_Goods_Stock Supplier_Goods_Stock { get; set; }

        [Column(TypeName = "MEDIUMINT")]
        [Range(0, 99999)]
        public uint _quantity { get; set; }
        
        [Column(TypeName = "MEDIUMINT")]
        [Range(0, 99999)]
        public uint _quantityReceived { get; set; }

    }
}