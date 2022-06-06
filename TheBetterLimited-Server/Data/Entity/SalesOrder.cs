namespace TheBetterLimited_Server.Data.Entity
{
    [Table("SalesOrder")]
    public class SalesOrder
    {
        [Key]
        [MaxLength(10)]
        [Column(TypeName = "char(10)")]
        public string ID { get; set; }

        [MaxLength(5)]
        [Column(TypeName = "char(5)")]
        public string _creatorId { get; set; }

        [ForeignKey("_creatorId")]
        public virtual Staff User { get; set; }

        [MaxLength(5)]
        [Column(TypeName = "char(5)")]
        public string _operatorId { get; set; }

        [ForeignKey("_operatorId")]
        public virtual Staff Operator { get; set; }

        [MaxLength(3)]
        [Column(TypeName = "char(3)")]
        public string _storeId { get; set; }

        [ForeignKey("_storeId")]
        public virtual Store Store { get; set; }

        public DateTime createdAt { get; set; }

        public DateTime updatedAt { get; set; }

        public SalesOrderStatus Status { get; set; } 

        public virtual List<SalesOrderItem> Items { get; set; }

    }

    public enum SalesOrderStatus
    {
        Placed,
        ReadyToDeliver,
        Delivering,
        Delivered,
        ReadyToInstall,
        Installing,
        Installed,
        NotDelivered,
        Completed,
        Cancelled,
        Refunded,
        PartiallyRefunded,
        NotCompleted
    }
}