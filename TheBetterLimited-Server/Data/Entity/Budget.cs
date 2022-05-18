namespace TheBetterLimited_Server.Data.Entity
{
    [Table("Budget")]
    public class Budget
    {
        [Key]
        [MaxLength(3)]
        [Column(TypeName = "char(3)")]
        public string ID { get; set;}

        [MaxLength(5)]
        [Column(TypeName = "char(5)")]
        public string _operatorId { get; set; }

        [ForeignKey("_operatorId")]
        public virtual Staff Operator { get; set; }

        [Range(0, 9999999)]
        [Column(TypeName = "DECIMAL(7,2)")]
        public decimal Amount { get; set; }

        public BudgetStatus Status { get; set; }

        [MaxLength(50)]
        [Column(TypeName = "varchar(50)")]
        public string Remarks { get; set; }
        public DateTime ResetDate { get; set; }
    }

    public enum BudgetStatus
    {
        Normal,
        Lock,
        Danger
    }
}