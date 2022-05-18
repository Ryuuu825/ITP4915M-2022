namespace TheBetterLimited_Server.Data.Entity
{
    [Table("Catalogue")]
    public class Catalogue
    {
        [Key]
        [MaxLength(3)]
        [Column(TypeName = "char(3)")]
        public string ID { get; set;}

        [MaxLength(20)]
        [Column(TypeName = "varchar(20)")]
        public string Name { get; set; }
    }
}