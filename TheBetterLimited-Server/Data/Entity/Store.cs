namespace TheBetterLimited_Server.Data.Entity
{
    [Table("Store")]
    public class Store
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

        [MaxLength(20)]
        public string? StoreName { get; set; }
    }
}