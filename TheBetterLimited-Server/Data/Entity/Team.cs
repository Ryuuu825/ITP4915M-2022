namespace TheBetterLimited_Server.Data.Entity
{
    [Table("Team")]
    public class Team
    {
        [Key]
        [MaxLength(3)]
        [Column(TypeName = "char(3)")]
        public string ID { get; set;}

        [MaxLength(3)]
        [Column(TypeName = "char(3)")]
        public string _departmentId { get; set;}

        [ForeignKey("_departmentId")]
        public virtual Department Department { get; set; }

        [MaxLength(10)]
        [Column(TypeName = "varchar(10)")]
        // The name of the team, which will be prsent to the manager when assigning appointment to them.
        public string Name { get; set; }
    }
}