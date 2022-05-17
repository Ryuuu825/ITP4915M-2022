namespace TheBetterLimited_Server.Data.Entity;

public class Staff
{
    [Key]
    [MaxLength(5)]
    [Column(TypeName = "char(5)")]
    public string Id {get; set; }


    [MaxLength(5)]
    [Column(TypeName = "char(5)")]
    public string? _AccountId {get; set; }

    [ForeignKey("_AccountId")]
    public virtual Account? acc { get; set; }


    [MaxLength(3)]
    [Column(TypeName = "char(3)")]
    public string _departmentId {get; set; }

    [ForeignKey("_departmentId")]
    public virtual Department department { get; set; }

    [MaxLength(3)]
    [Column(TypeName = "char(3)")]
    public string _positionId {get; set; }

    [ForeignKey("_positionId")]
    public virtual Position position { get; set; }

    // [MaxLength(3)]
    // [Column(TypeName = "char(3)")]
    // public string? _warehouseId {get; set; }

    // [ForeignKey("_warehouseId")]
    // public virtual Warehouse warehouse { get; set; }

    // [MaxLength(3)]
    // [Column(TypeName = "char(3)")]
    // public string? _storeId {get; set; }

    // [ForeignKey("_storeId")]
    // public virtual Store store { get; set; }

    // [MaxLength(3)]
    // [Column(TypeName = "char(3)")]
    // public string? _teamId {get; set; }

    // [ForeignKey("_teamId")]
    // public virtual Team team { get; set; }

    [MaxLength(10)]
    [Column(TypeName = "varchar(10)")]
    public string FirstName { get; set; }

    [MaxLength(10)]
    [Column(TypeName = "varchar(10)")]
    public string LastName { get; set; }

    [Column(TypeName = "char(1)")]
    public char? Sex {get; set;}

    [Range(0, 99)]
    [Column(TypeName = "integer(2)")]
    public short? Age {get; set;}

    [Phone]
    [Column(TypeName = "varchar(15)")]
    public string? Phone { get; set;}
}