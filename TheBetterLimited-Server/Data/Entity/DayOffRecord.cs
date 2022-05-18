namespace TheBetterLimited_Server.Data.Entity
{
    [Table("DayOffRecord")]
    public class DayOffRecord
    {
        [Key]
        [MaxLength(5)]
        [Column(TypeName = "char(5)")]
        public string ID { get; set;}

        [MaxLength(5)]
        [Column(TypeName = "char(5)")]
        public string _staffID { get; set; }

        [ForeignKey("_staffID")]
        public virtual Staff Staff { get; set; }

        public DateTime OffDate { get; set; }

        [MaxLength(50)]
        [Column(TypeName = "varchar(50)")]
        public string Reason { get; set; }
    }
}