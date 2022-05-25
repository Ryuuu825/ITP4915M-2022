namespace TheBetterLimited_Server.Data.Entity
{
    [Table("Position")]
    public class Position
    {
        [Key]
        [MaxLength(3)]
        [Column(TypeName = "char(3)")]
        public string Id { get; set; }

        [MaxLength(3)]
        [Column(TypeName = "char(3)")]
        public string _departmentId { get; set; }

        [ForeignKey("_departmentId")]
        public virtual Department department { get; set; }

        [MaxLength(30)]
        [Column(TypeName = "varchar(30)")]
        public string? jobTitle { get; set; } = "admin";

        public virtual ICollection<Permission> permissions { get; set; }


    }
}