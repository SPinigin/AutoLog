using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AutoLog.Models
{
    public class Contact
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ContactID")]
        public int ContactID { get; set; }

        [Required]
        public int OrganizationID { get; set; }

        [Required]
        [Column("OrganizationTaxNumber")]
        [StringLength(255)]
        public string OrganizationTaxNumber { get; set; }

        [Required]
        [Column("Position")]
        [StringLength(255)]
        public string Position { get; set; }

        [Required]
        [Column("HeadFIO")]
        [StringLength(255)]
        public string HeadFIO { get; set; }

        [Required]
        [Column("HeadPhoneNumber")]
        [StringLength(255)]
        public string HeadPhoneNumber { get; set; }

        [Column("HeadMobilePhoneNumber")]
        [StringLength(255)]
        public string HeadMobilePhoneNumber { get; set; }

        [Column("GeneralPhoneNumber")]
        [StringLength(255)]
        public string GeneralPhoneNumber { get; set; }

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

        [Required]
        [Column("OrganizationAddress")]
        [StringLength(255)]
        public string OrganizationAddress { get; set; }

        [Required]
        [Column("OrganizationEmail")]
        [StringLength(255)]
        [EmailAddress]
        public string OrganizationEmail { get; set; }

        public Organization Organization { get; set; }
    }
}
