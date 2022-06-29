namespace TheBetterLimited_Server.Data.Entity
{
    [Table("RestockRequest_Supplier_Goods")]
    public class  RestockRequest_Supplier_Goods
    {
        [MaxLength(10)]
        [Column(TypeName = "char(10)")]
        public string _restockRequestId { get; set;}

        [ForeignKey("_restockRequestId")]
        public virtual RestockRequest RestockRequest { get; set; }

        [MaxLength(9)]
        [Column(TypeName = "char(9)")]
        public string _supplierGoodsId { get; set;}

        [ForeignKey("_supplierGoodsId")]
        public virtual Supplier_Goods Supplier_Goods { get; set; }

        [Column(TypeName = "MEDIUMINT")]
        [Range(0, 99999)]
        public uint _quantity { get; set; }
        
        [Column(TypeName = "MEDIUMINT")]
        [Range(0, 99999)]
        public uint _quantityReceived { get; set; }

    }
}