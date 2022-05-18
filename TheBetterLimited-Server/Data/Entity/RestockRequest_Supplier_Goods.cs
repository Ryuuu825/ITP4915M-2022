namespace TheBetterLimited_Server.Data.Entity
{
    [Table("RestockRequest_Supplier_Goods")]
    public class RestockRequest_Supplier_Goods
    {
        [MaxLength(10)]
        [Column(TypeName = "char(10)")]
        public string _restockRequestId { get; set;}

        [ForeignKey("_restockRequestId")]
        public virtual RestockRequest RestockRequest { get; set; }

        [MaxLength(5)]
        [Column(TypeName = "char(5)")]
        public string _supplierGoodsId { get; set;}

        [ForeignKey("_supplierId")]
        public virtual Supplier_Goods Supplier_Goods { get; set; }

        [Column(TypeName = "MEDIUMINT")]
        [Range(0, 99999)]
        public uint _quantity { get; set; }
    }
}