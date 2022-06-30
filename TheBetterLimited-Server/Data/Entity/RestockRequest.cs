namespace TheBetterLimited_Server.Data.Entity
{
    [Table("RestockRequest")]
    public class RestockRequest
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
        public string _operatorId { get; set;}

        [ForeignKey("_operatorId")]
        public virtual Staff Operator { get; set; }

        [MaxLength(3)]
        [Column(TypeName = "char(3)")]
        public string _storeId { get; set; }

        [ForeignKey("_storeId")]
        public virtual Location Location { get; set; }

        public DateTime CreateTime { get; set; }

        public DateTime OperateTime { get; set; }

        public RestockRequestStatus Status { get; set; }
        public virtual List<RestockRequest_Supplier_Goods_Stock> Items { get; set; }
        
    }

    public enum RestockRequestStatus
    {
        Pending,
        Approved,
        Rejected,
        Cancelled,
        Handling,
        Completed
    }
}