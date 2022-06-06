namespace TheBetterLimited_Server.Data.Entity
{
    [Table("Appointment")]
    public class Appointment
    {
        [Key]
        [MaxLength(10)]
        [Column(TypeName = "char(10)")]
        public string ID { get; set;}

        [MaxLength(10)]
        [Column(TypeName = "char(10)")]
        public string? _sessionId { get; set;}

        [ForeignKey("_sessionId")]
        public virtual Session? Session { get; set; }

        [MaxLength(10)]
        [Column(TypeName = "char(10)")]
        public string _departmentId { get; set;}

        [ForeignKey("_departmentId")]
        public virtual Department Department { get; set; }

        [MaxLength(10)]
        [Column(TypeName = "char(10)")]
        public string? _teamId { get; set;}

        [ForeignKey("_teamId")]
        public virtual Team? Team { get; set; }

        public string _customerId { get; set;}

        [ForeignKey("_customerId")]
        public virtual Customer Customer { get; set; }

        public virtual List<SalesOrderItem_Appointment> SaleOrderItem_Appointments { get; set; }
    }
}