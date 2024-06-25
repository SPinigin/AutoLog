using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace AutoLog.Models
{
    public class Organization : IdentityUser<int>
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("OrganizationID")]
        public int OrganizationID { get; set; }

        [Required]
        [StringLength(255)]
        [Column("OrganizationName")]
        public string OrganizationName { get; set; }

        [Required]
        [StringLength(255)]
        public string Username { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string PasswordHash { get; set; }

        public Contact Contact { get; set; }
        public ICollection<Car> Cars { get; set; }
    }
}
