namespace TheBetterLimited_Server.Data.Entity
{
    public class Menu
    {
        [Key]
        [MaxLength(3)]
        [Column(TypeName = "char(3)")]
        public string Id { get; set; }

        [MaxLength(20)]
        [Column(TypeName = "varchar(20)")]
        public string Name { get; set; }

        public virtual ICollection<Permission> permissions { get; set; }
    }
}