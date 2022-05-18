namespace TheBetterLimited_Server.Data.Entity
{
    [Table("Supplier_Goods_Stock")]
    public class Supplier_Goods_Stock
    {

        [MaxLength(3)]
        [Column(TypeName = "char(3)")]
        public string _locationId { get; set; }

        [ForeignKey("_locationId")]
        public virtual Location Location { get; set; }

        [MaxLength(5)]
        [Column(TypeName = "char(5)")]
        public string _supplierGoodsId { get; set;}

        [ForeignKey("_supplierId")]
        public virtual Supplier_Goods Supplier_Goods { get; set; }

        [Column(TypeName = "MEDIUMINT")]
        [Range(0, 99999)]
        public uint Quantity { get; set; }

        [Column(TypeName = "MEDIUMINT")]
        [Range(0, 99999)]
        public uint MaxLimit { get; set; }

        [Column(TypeName = "MEDIUMINT")]
        [Range(0, 99999)]
        public uint MinLimit { get; set; }

        [Column(TypeName = "MEDIUMINT")]
        [Range(0, 99999)]
        public uint ReorderLevel { get; set; }

        public virtual ICollection<DefectItemRecord> DefectItemRecords { get; set; }
        public virtual ICollection<SalesOrderItem> SalesOrderItems { get; set; }
    
    }
}