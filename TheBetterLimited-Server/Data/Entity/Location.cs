

namespace TheBetterLimited_Server.Data.Entity
{
    using System.ComponentModel;

    [Table("Location")]
    public class Location
    {
        [Key]
        [MaxLength(3)]
        [Column(TypeName = "char(3)")]
        public string Id { get; set; }

        [MaxLength(100)]
        [Column(TypeName = "varchar(100)")]
        [Description("The phyiscal location address of the location")]
        public string Loc { get; set; }

        [MaxLength(30)]
        public string? Name { get; set; }
    }
}