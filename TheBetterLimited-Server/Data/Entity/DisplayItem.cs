namespace TheBetterLimited_Server.Data.Entity
{
    [Table("DisplayItem")]
    public class DisplayItem
    {
        [Key]
        [MaxLength(10)]
        [Column(TypeName = "char(10)")]
        public string ID { get; set;}

        [MaxLength(10)]
        [Column(TypeName = "char(10)")]
        public string _goodsId { get; set;}

        [ForeignKey("_goodsId")]
        public virtual Goods Goods { get; set; }

        [MaxLength(10)]
        [Column(TypeName = "char(10)")]
        public string _locationId { get; set;}

        [ForeignKey("_locationId")]
        public virtual Location Location { get; set; }

        [MaxLength(5)]
        [Column(TypeName = "char(5)")]
        public string _supplierId { get; set;}

        [ForeignKey("_supplierId")]
        public virtual Supplier Supplier { get; set; }

        // [Column(TypeName = "INT")]
        // public uint SellingPrice { get; set; }

        [Column(TypeName = "char(1)")]
        public DisplayItemStatus Status { get; set; }
    }

    public enum DisplayItemStatus
    {
        Displaying,
        Sold
    }
}

