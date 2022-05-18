namespace TheBetterLimited_Server.Data.Entity
{
    [Table("Warehouse")]
    public class Warehouse
    {
        [Key]
        [MaxLength(3)]
        [Column(TypeName = "char(3)")]
        public string ID { get; set;}

        [MaxLength(3)]
        [Column(TypeName = "char(3)")]
        public string _locationID { get; set; }

        [ForeignKey("_locationID")]
        public virtual Location Location { get; set; }
    }
}