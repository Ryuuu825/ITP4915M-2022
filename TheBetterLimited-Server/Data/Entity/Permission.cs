namespace TheBetterLimited_Server.Data.Entity
{
    public class Permission
    {

        [MaxLength(3)]
        [Column(TypeName = "char(3)")]
        public string _menuId { get; set; }

        [Key , ForeignKey("_menuId")]
        public virtual Menu menu { get; set; }  

        [MaxLength(3)]
        [Column(TypeName = "char(3)")]
        public string _positionId { get; set; } 

        [Key , ForeignKey("_positionId")]
        public virtual Position position { get; set; } 

        [Column(TypeName = "tinyint(1)")]
        // GET
        public bool? read { get; set; }

        [Column(TypeName = "tinyint(1)")]
        // POST, PUT
        public bool? write { get; set; }

        [Column(TypeName = "tinyint(1)")]
        // DELETE
        public bool? delete { get; set; }

    }
}