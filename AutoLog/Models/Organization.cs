using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AutoLog.Models
{
    public class Organization
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("OrganizationID")]
        public int OrganizationID { get; set; }

        [Required]
        [MaxLength(255)]
        [Column("OrganizationName")]
        public string OrganizationName { get; set; }

        //[Required]
        //[StringLength(255)]
        //public string Username { get; set; }

        //[Required]
        //[DataType(DataType.Password)]
        //public string PasswordHash { get; set; }

        public ICollection<Contact> Contacts { get; set; }

        public ICollection<Truck> Trucks { get; set; }
    }
}
