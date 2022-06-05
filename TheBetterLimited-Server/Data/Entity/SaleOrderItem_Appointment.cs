namespace TheBetterLimited_Server.Data.Entity
{
    [Table("SaleOrderItem_Appointment")]
    public class SalesOrderItem_Appointment
    {
        [Key]
        public string _salesOrderItemId { get; set; }

        [ForeignKey("_salesOrderItemId")]
        public virtual SalesOrderItem SalesOrderItem { get; set; }

        [Key]
        [ForeignKey("_appointmentId")]
        public string _appointmentId { get; set; }
        public virtual Appointment Appointment { get; set; }
    }
}