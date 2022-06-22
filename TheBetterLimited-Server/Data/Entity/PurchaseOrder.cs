namespace TheBetterLimited_Server.Data.Entity
{
    [Table("PurchaseOrder")]
    public class PurchaseOrder
    {
        [Key]
        [MaxLength(10)]
        [Column(TypeName = "char(10)")]
        public string ID { get; set;}

        [MaxLength(5)]
        [Column(TypeName = "char(5)")]
        public string _createrId { get; set;}

        [ForeignKey("_createrId")]
        public virtual Staff Creater { get; set; }


        [MaxLength(5)]
        [Column(TypeName = "char(5)")]
        public string? _operatorId { get; set;}

        [ForeignKey("_operatorId")]
        public virtual Staff? Operator { get; set; }

        public string _supplierId { get; set;}

        [ForeignKey("_supplierId")]
        public virtual Supplier Supplier { get; set; }




        // warehouse
        [MaxLength(3)]
        [Column(TypeName = "char(3)")]
        public string _warehouseId { get; set; }

        [ForeignKey("_warehouseId")]
        public virtual Warehouse Warehouse { get; set; }

        public DateTime CreateTime { get; set; }

        public DateTime OperateTime { get; set; }

        public virtual PurchaseOrderStatus Status { get; set; }
        public virtual List<PurchaseOrder_Supplier_Goods> Items { get; set; }
    }

    public enum PurchaseOrderStatus
    {
        Pending,
        PendingApproval,
        Rejected,
        Cancelled,
        SentToSupplier,
        Inbound,
        Completed
    }
}