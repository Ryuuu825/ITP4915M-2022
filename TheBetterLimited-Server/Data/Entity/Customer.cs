namespace TheBetterLimited_Server.Data.Entity
{
    [Table("Customer")]
    public class Customer
    {
        [Key]
        [MaxLength(10)]
        [Column(TypeName = "char(10)")]
        public string ID { get; set;}

        [MaxLength(20)]
        [Column(TypeName = "varchar(20)")]
        public string Name { get; set; }

        [MaxLength(50)]
        [Column(TypeName = "varchar(50)")]
        public string? Address { get; set; }

        [MaxLength(15)]
        [Column(TypeName = "varchar(15)")]
        public string Phone { get; set; }
    }
}