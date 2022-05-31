namespace TheBetterLimited_Server.Data.Entity
{
    [Table("Supplier_Goods")]
    [PrimaryKey("ID" , "_supplierId" , "_goodsId")]
    public class Supplier_Goods
    {
        // composite primary key with supplierId and goodsId
        [Key]
        [MaxLength(9)]
        [Column(TypeName = "char(9)")]
        public string ID { get; set; }

        [MaxLength(5)]
        [Column(TypeName = "char(5)")]
        public string _supplierId { get; set;}

        [ForeignKey("_supplierId")]
        public virtual Supplier Supplier { get; set; }

        [MaxLength(10)]
        [Column(TypeName = "char(10)")]
        public string _goodsId { get; set;}

        [ForeignKey("_goodsId")]
        public virtual Goods Goods { get; set; }

        [Column(TypeName = "DECIMAL(7,2)")]
        public double? Price { get; set; }

        public virtual ICollection<Supplier_Goods_Stock> Supplier_Goods_Stocks { get; set; }
        public virtual ICollection<PurchaseOrder_Supplier_Goods> PurchaseOrder_Supplier_Goodss { get; set; }
        public virtual ICollection<RestockRequest_Supplier_Goods> RestockRequest_Supplier_Goodss { get; set; }
    }
}