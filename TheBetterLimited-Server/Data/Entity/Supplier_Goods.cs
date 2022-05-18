namespace TheBetterLimited_Server.Data.Entity
{
    [Table("Supplier_Goods")]
    public class Supplier_Goods
    {
        public string ID { get; set; }

        [MaxLength(5)]
        [Column(TypeName = "char(5)")]
        public string _supplierId { get; set;}

        [ForeignKey("_departmentId")]
        public virtual Supplier Supplier { get; set; }

        [MaxLength(10)]
        [Column(TypeName = "char(10)")]
        public string _goodsId { get; set;}

        [ForeignKey("_departmentId")]
        public virtual Goods Goods { get; set; }

        [Column(TypeName = "DECIMAL(7,2)")]
        public decimal _price { get; set; }


        public virtual ICollection<Supplier_Goods_Stock> Supplier_Goods_Stocks { get; set; }
    }
}