using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AutoLog.Models
{
    public class Organization
    {
        [Key]
        [ForeignKey("Contact")]
        [Column("OrganizationID")]
        public int OrganizationID { get; set; }

        [Required]
        [StringLength(255)]
        [Column("OrganizationName")]
        public string OrganizationName { get; set; }

        [Required]
        [StringLength(255)]
        [Column("CuratorFIO")]
        public string CuratorFIO { get; set; }

        [Required]
        [StringLength(12)]
        [Column("CuratorMobilePhoneNumber")]
        public string CuratorMobilePhoneNumber { get; set; }

        [StringLength(12)]
        [Column("CuratorLandlinePhoneNumber")]
        public string CuratorLandlinePhoneNumber { get; set; }

        [StringLength(12)]
        [Column("CuratorAddPhoneNumber")]
        public string CuratorAddPhoneNumber { get; set; }
    }
}
