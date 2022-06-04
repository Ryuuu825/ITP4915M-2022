namespace TheBetterLimited_Server.Data.Entity
{
    public class SessionSetting
    {
        [Key]
        [MaxLength(10)]
        [Column(TypeName = "char(10)")]
        public string ID { get; set;}

        public TimeOnly StartTime { get; set; }

        public TimeOnly EndTime { get; set; }

        [Column(TypeName = "TINYINT")]
        public int NumOfAppointments { get; set; }
        
    }
}