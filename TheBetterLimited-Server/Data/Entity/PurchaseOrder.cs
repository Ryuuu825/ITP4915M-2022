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


        // warehouse
        [MaxLength(3)]
        [Column(TypeName = "char(3)")]
        public string _warehouseId { get; set; }

        [ForeignKey("_warehouseId")]
        public virtual Warehouse Warehouse { get; set; }

        public DateTime CreateTime { get; set; }

        public DateTime OperateTime { get; set; }

        public PurchaseOrderStatus Status { get; set; }
    }

    public enum PurchaseOrderStatus
    {
        Pending,
        Approved,
        Rejected,
        Cancelled,
        SentToSupplier,
        ReceivedFromSupplier,
        Completed
    }
}