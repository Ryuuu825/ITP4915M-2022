namespace TheBetterLimited_Server.Data.Entity
{
    public class Department
    {
        [Key]
        [MaxLength(3)]
        [Column(TypeName = "char(3)")]
        public string Id { get; set; }

        [MaxLength(20)]
        [Column(TypeName = "varchar(20)")]
        public string Name { get; set; }

        // [MaxLength(3)]
        // [Column(TypeName = "char(3)")]
        // public string _budgetId { get; set; }

        // [ForeignKey("_budgetId")]
        // public Budget budget { get; set; }

        public virtual ICollection<Staff> staffs { get; set; }
    }
}