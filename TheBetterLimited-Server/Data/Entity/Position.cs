namespace TheBetterLimited_Server.Data.Entity
{
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
        public Department department { get; set; }

        [MaxLength(20)]
        [Column(TypeName = "varchar(20)")]
        public string? jobTitle { get; set; } = "admin";

        public ICollection<Permission> permissions { get; set; }

    }
}