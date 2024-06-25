using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AutoLog.Models
{
    public class Trailer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TrailerID { get; set; }

        public int CarID { get; set; }

        [Required]
        [MinLength(10)]
        [StringLength(10)]
        [Column("TrailerSTS")]
        public string TrailerSTS { get; set; }

        [Required]
        [MinLength(10)]
        [MaxLength(15)]
        [Column("TrailerPTS")]
        public string TrailerPTS { get; set; }

        [Required]
        [MinLength(8)]
        [StringLength(9)]
        [Column("TrailerLicensePlate")]
        public string TrailerLicensePlate { get; set; }

        [Required]
        [Column("TrailerLoadCapacity")]
        public double TrailerLoadCapacity { get; set; }

        [Required]
        [Column("TrailerLenght")]
        public double CarLenght { get; set; }

        public Car Car { get; set; }
    }
}
