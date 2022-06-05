namespace TheBetterLimited_Server.Data.Entity
{
    public class SessionSetting
    {
        [Key]
        [MaxLength(10)]
        [Column(TypeName = "char(10)")]
        public string ID { get; set;}

        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }

        [Column(TypeName = "TINYINT")]
        public int NumOfAppointments { get; set; }
        
    }
}