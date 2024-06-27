using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AutoLog.Models
{
    public class Car
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("CarID")]
        public int CarID { get; set; }

        [ForeignKey("CargoDepotID")]
        public CargoDepot CargoDepot { get; set; }

        [Required]
        public int OrganizationID { get; set; }

        [Required]
        [StringLength(255)]
        [Column("CarName")]
        public string CarName { get; set; }

        [Required]
        [Range(1886,2100)]
        [Column("CarYear")]
        public int CarYear { get; set; }

        [Required]
        [MinLength(10)]
        [StringLength(10)]
        [Column("CarSTS")]
        public string CarSTS { get; set; }

        [Required]
        [MinLength(10)]
        [MaxLength(15)]
        [Column("CarPTS")]
        public string CarPTS { get; set; }

        [Required]
        [MinLength(8)]
        [StringLength(9)]
        [Column("CarLicensePlate")]
        public string CarLicensePlate { get; set; }

        [Required]
        [Column("CarLoadCapacity")]
        public double CarLoadCapacity { get; set; }

        [Required]
        [Column("CarLenght")]
        public double CarLenght { get; set; }

        [Required]
        [StringLength(30)]
        [Column("CarStatus")]
        public string CarStatus { get; set; }

        [Column("CreatedDate")]
        public DateTime CreatedDate { get; set; } = DateTime.Now;

        [Column("UpdatedDate")]
        public DateTime UpdatedDate {  get; set; } = DateTime.Now;

        public ICollection<Trailer> Trailers { get; set; }
    }
}
