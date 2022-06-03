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

        public TimeOnly StartTime { get; set; }

        public TimeOnly EndTime { get; set; }

        public DateOnly Date { get; set; }

        [Column(TypeName = "TINYINT")]
        public byte NumOfAppointments { get; set; }
    }
}