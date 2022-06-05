namespace TheBetterLimited_Server.Data.Entity
{
    [Table("Session")]
    public class Session
    {
        [Key]
        [MaxLength(10)]
        [Column(TypeName = "char(10)")]
        public string ID { get; set;}

        [MaxLength(3)]
        [Column(TypeName = "char(3)")]
        public string _departmentId { get; set;}

        [ForeignKey("_departmentId")]
        public virtual Department Department { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }

        public DateTime Date { get; set; }

        [Column(TypeName = "TINYINT")]
        public byte NumOfAppointments { get; set; }
    }
}