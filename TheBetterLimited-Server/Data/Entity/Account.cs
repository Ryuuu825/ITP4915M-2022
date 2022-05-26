
namespace TheBetterLimited_Server.Data.Entity;

using System.ComponentModel;

[Table("Account")]
public class Account 
{
    public Account()
    {
    }

    [Required]
    [MaxLength(5)]
    [Column(TypeName = "char(5)")]
    public string Id { get; set; }

    [Required]
    [MaxLength(10)]
    [Column(TypeName = "char(10)")]
    public string UserName { get; set; }

    [Required]
    [MaxLength(100)]
    [Column(TypeName = "varchar(100)")]
    [Description("The hashed password of the user account")]
    public string Password { get; set; }

    [Required]
    [EmailAddress]
    [Column(TypeName = "varchar(50)")]
    public string EmailAddress { get; set; }


    [Required]
    [MaxLength(1)]
    [RegularExpression("[NL]")]
    [Column(TypeName = "char(1)")]
    public string Status { get; set; }

    [MaxLength(5)]
    [Column(TypeName = "char(5)")]
    public string _StaffId {get; set; }
    [Column(TypeName = "varchar(100)")] public string? Remarks { get; set; }

    [ForeignKey("_StaffId")]
    public virtual Staff Staff { get; set; }

    [Column(TypeName = "int(1)")]
    [Description("How many time the user fail to login")]
    public int LoginFailedCount { get; set; }

    [DataType(DataType.Date)]
    [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
    [Description("The date when user login attempt failed")]
    public DateTime? LoginFailedAt { get; set; }

    [DataType(DataType.Date)]
    [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
    public DateTime? LastLogin { get; set; }

    [DataType(DataType.Date)]
    [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
    [Description("The time system unlock user account")]
    public DateTime? unlockDate { get; set; }


    public byte[]? Icon { get; set; }
}