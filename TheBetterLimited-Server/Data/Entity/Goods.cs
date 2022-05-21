namespace TheBetterLimited_Server.Data.Entity
{
    [Table("Goods")]
    public class Goods
    {
        [Key]
        [MaxLength(10)]
        [Column(TypeName = "char(10)")]
        public string Id { get; set;}

        [MaxLength(5)]
        [Column(TypeName = "char(5)")]
        public string _catalogueId { get; set; }

        [ForeignKey("_catalogueId")]
        public virtual Catalogue Catalogue { get; set; }

        [MaxLength(30)]
        [Column(TypeName = "varchar(30)")]
        [AppLogic.Attribute.Translatable]
        public string Name { get; set; }

        [MaxLength(50)]
        [Column(TypeName = "varchar(50)")]
        [AppLogic.Attribute.Translatable]
        public string Description { get; set; }

        [Column(TypeName = "SMALLINT")]
        public double Price { get; set; }

        [MaxLength(15)]
        [Column(TypeName = "varchar(15)")]
        public string? GTINNode { get; set; }

        public GoodsSize? Size { get; set; }

        [Column(TypeName = "int(1)")]
        public GoodsStatus Status { get; set; }

        [Column(TypeName = "TINYINT")]
        public short PhotoAmt {get ; set;}


    }

    public enum GoodsSize
    {
        Small ,
        Medium ,
        Large 
    }

    public enum GoodsStatus 
    {
        Selling,
        PhasingOut,
        StopSelling
    }
}