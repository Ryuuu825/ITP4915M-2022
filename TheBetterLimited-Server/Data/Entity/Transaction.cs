namespace TheBetterLimited_Server.Data.Entity
{
    [Table("Transaction")]
    public class Transaction
    {
        [Key]
        [MaxLength(10)]
        [Column(TypeName = "char(10)")]
        public string ID { get; set;}


        [MaxLength(10)]
        [Column(TypeName = "char(10)")]
        public string _salesOrderId { get; set; }

        [ForeignKey("_salesOrderId")]
        public virtual SalesOrder SalesOrder { get; set; }

        [Column(TypeName = "DECIMAL(7,2)")]
        [Range(0, 99999)]
        public decimal Amount { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}