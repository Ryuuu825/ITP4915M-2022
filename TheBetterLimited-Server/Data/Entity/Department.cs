namespace TheBetterLimited_Server.Data.Entity
{
    [Table("Department")]
    public class Department
    {
        [Key]
        [MaxLength(3)]
        [Column(TypeName = "char(3)")]
        public string Id { get; set; }

        [MaxLength(30)]
        [Column(TypeName = "varchar(30)")]
        public string? Name { get; set; }

        [MaxLength(3)]
        [Column(TypeName = "char(3)")]
        public string? _budgetId { get; set; }

        [ForeignKey("_budgetId")]
        public virtual Budget? budget { get; set; }

        public virtual ICollection<Staff> staffs { get; set; }
        public virtual ICollection<Team> teams { get; set; }
    }
}