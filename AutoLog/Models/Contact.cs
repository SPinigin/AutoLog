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
        [MaxLength(255)]
        public string OrganizationTaxNumber { get; set; }

        [Required]
        [Column("Position")]
        [MaxLength(255)]
        public string Position { get; set; }

        [Required]
        [Column("HeadFIO")]
        [MaxLength(255)]
        public string HeadFIO { get; set; }

        [Required]
        [Column("HeadPhoneNumber")]
        [MaxLength(255)]
        public string HeadPhoneNumber { get; set; }

        [Column("HeadMobilePhoneNumber")]
        [StringLength(255)]
        public string HeadMobilePhoneNumber { get; set; }

        [Column("GeneralPhoneNumber")]
        [MaxLength(255)]
        public string GeneralPhoneNumber { get; set; }

        [Required]
        [MaxLength(255)]
        [Column("CuratorFIO")]
        public string CuratorFIO { get; set; }

        [Required]
        [MaxLength(12)]
        [Column("CuratorMobilePhoneNumber")]
        public string CuratorMobilePhoneNumber { get; set; }

        [MaxLength(12)]
        [Column("CuratorLandlinePhoneNumber")]
        public string CuratorLandlinePhoneNumber { get; set; }

        [MaxLength(12)]
        [Column("CuratorAddPhoneNumber")]
        public string CuratorAddPhoneNumber { get; set; }

        [Required]
        [Column("OrganizationAddress")]
        [MaxLength(255)]
        public string OrganizationAddress { get; set; }

        [Required]
        [Column("OrganizationEmail")]
        [MaxLength(255)]
        [EmailAddress]
        public string OrganizationEmail { get; set; }

        [ForeignKey("OrganizationID")]
        public Organization Organization { get; set; }
    }
}
