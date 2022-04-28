using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TheBetterLimited_Server.AppLogic.Dto
{
    public class Acc
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string Email { get; set; }

        [MaxLength(10)]
        public string Phone { get; set; }

        [Column(TypeName = "varchar(10)")]
        public string? Address { get; set; }

        public static void tesing() { }
    }
}

