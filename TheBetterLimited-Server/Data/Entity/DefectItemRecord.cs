namespace TheBetterLimited_Server.Data.Entity
{
    [Table("DefectItemRecord")]
    public class DefectItemRecord
    {
        // [Key]
        // [MaxLength(10)]
        // [Column(TypeName = "char(10)")]
        // public string ID { get; set;}

        public string _supplierGoodsStockId { get; set; }

        [ForeignKey("_supplierGoodsStockId")]
        public virtual Supplier_Goods_Stock SupplierGoodsStock { get; set; }

        [MaxLength(10)]
        [Column(TypeName = "char(10)")]
        public string? _salesOrderId { get; set; }

        [ForeignKey("_salesOrderId")]
        public virtual SalesOrder? SalesOrder { get; set; }

        [MaxLength(10)]
        [Column(TypeName = "char(10)")]
        public string _creatorId { get; set; }

        [ForeignKey("_creatorId")]
        public virtual Staff User { get; set; }

        [MaxLength(10)]
        [Column(TypeName = "char(10)")]
        public string _operatorId { get; set; }

        [ForeignKey("_operatorId")]
        public virtual Staff Operator { get; set; }

        public DefectItemRecordStatus Status { get; set; }

        public DateTime createdAt { get; set; }

        public DateTime updatedAt { get; set; }

        [MaxLength(50)]
        [Column(TypeName = "varchar(50)")]
        public string? Remark { get; set; }
        public DefectItemHandleStatus HandleStatus { get; set; }
        public string? _customerId { get; set; }

        [ForeignKey("_customerId")]
        public virtual Customer? customer { get; set; }
    }
    public enum DefectItemHandleStatus
    {
        Refund,
        Exchange
    }

    public enum DefectItemRecordStatus 
    {
        Pending,
        Handling,
        Returned
    }
}