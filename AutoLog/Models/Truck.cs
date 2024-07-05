using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AutoLog.Models
{
    public class Truck
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("TruckID")]
        public int TruckID { get; set; }

        public int? CargoDepotID { get; set; }
        [ForeignKey("CargoDepotID")]
        public CargoDepot CargoDepot { get; set; }

        public int OrganizationID { get; set; }
        [ForeignKey("OrganizationID")]
        public Organization Organization { get; set; }

        [Required]
        [MaxLength(255)]
        [Column("TruckName")]
        public string TruckName { get; set; }

        [Required]
        [Range(1886,2100)]
        [Column("TruckYear")]
        public int TruckYear { get; set; }

        [Required]
        [MinLength(10)]
        [StringLength(10)]
        [Column("TruckSTS")]
        public string TruckSTS { get; set; }

        [Required]
        [MinLength(10)]
        [MaxLength(15)]
        [Column("TruckPTS")]
        public string TruckPTS { get; set; }

        [Required]
        [MinLength(8)]
        [MaxLength(9)]
        [Column("TruckLicensePlate")]
        public string TruckLicensePlate { get; set; }

        [Required]
        [Column("TruckLoadCapacity")]
        public double TruckLoadCapacity { get; set; }

        [Required]
        [Column("TruckLenght")]
        public double TruckLenght { get; set; }

        //[Required]
        //[MaxLength(30)]
        //[Column("TruckStatus")]
        //public string TruckStatus { get; set; }

        [Column("CreatedDate")]
        public DateTime CreatedDate { get; set; } = DateTime.Now;

        [Column("UpdatedDate")]
        public DateTime UpdatedDate {  get; set; } = DateTime.Now;

        public int? TrailerID { get; set; }
        [ForeignKey("TrailerID")]
        public Trailer Trailer { get; set; }

        public bool IsLoaded { get; set; }
    }
}
