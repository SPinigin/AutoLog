using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AutoLog.Models
{
    public class CargoDepot
    {
        [Key]
        public int CargoDepotID { get; set; }

        [Required]
        [StringLength(255)]
        public string CargoDepotName { get; set; }

        [Required]
        [StringLength(255)]
        public string CargoDepotLocation { get; set; }

        //[Required]
        //[StringLength(255)]

    }
}
