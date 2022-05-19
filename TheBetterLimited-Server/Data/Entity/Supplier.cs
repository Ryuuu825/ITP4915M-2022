namespace TheBetterLimited_Server.Data.Entity
{
    [Table("Supplier")]
    public class Supplier
    {
        [Key]
        [MaxLength(5)]
        [Column(TypeName = "char(5)")]
        public string ID { get; set;}

        [MaxLength(15)]
        [Column(TypeName = "varchar(15)")]
        public string Name { get; set; }


        [MaxLength(15)]
        [Column(TypeName = "varchar(15)")]
        public string? Phone { get; set; }

        [MaxLength(15)]
        [Column(TypeName = "varchar(15)")]
        public string? Contact { get; set; }

        [MaxLength(15)]
        [Column(TypeName = "varchar(15)")]
        public string? Email { get; set; }

        [MaxLength(50)]
        [Column(TypeName = "varchar(50)")]
        public string? Address { get; set; }


        public virtual ICollection<Supplier_Goods> Supplier_Goods { get; set; }
    }
}