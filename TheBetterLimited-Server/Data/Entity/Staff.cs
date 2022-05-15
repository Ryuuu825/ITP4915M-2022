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
    public Account? acc { get; set; }


    [MaxLength(3)]
    [Column(TypeName = "char(3)")]
    public string _departmentId {get; set; }

    [ForeignKey("_departmentId")]
    public Department department { get; set; }

    [MaxLength(3)]
    [Column(TypeName = "char(3)")]
    public string _positionId {get; set; }

    [ForeignKey("_positionId")]
    public Position position { get; set; }



    // [ForeignKey("WarehouseId")]
    // [MaxLength(3)]
    // [Column(TypeName = "char(3)")]
    // public string? _warehouseId {get; set; }

    // [ForeignKey("StoreId")]
    // [MaxLength(3)]
    // [Column(TypeName = "char(3)")]
    // public string? _storeId {get; set; }

    // [ForeignKey("TeamId")]
    // [MaxLength(3)]
    // [Column(TypeName = "char(3)")]
    // public string? _teamId {get; set; }

    [MaxLength(10)]
    [Column(TypeName = "varchar(10)")]
    public string FirstName { get; set; }

    [MaxLength(10)]
    [Column(TypeName = "varchar(10)")]
    public string lastName { get; set; }

    [Column(TypeName = "char(1)")]
    public char? sex {get; set;}

    [Range(0, 99)]
    [Column(TypeName = "integer(2)")]
    public short? age {get; set;}

    [Phone]
    [Column(TypeName = "varchar(15)")]
    public string? phone { get; set;}



    
}