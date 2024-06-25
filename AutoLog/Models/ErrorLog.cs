using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AutoLog.Models
{
    public class ErrorLog
    {
        [Key]
        public int ErrorLogID { get; set; }

        public int? OrganizationID { get; set; }

        [Required]
        public string ErrorMessage { get; set; }

        [Required]
        public string StackTrace { get; set; }

        [Required]
        public DateTime DateOccurred { get; set; }

        public Organization Organization { get; set; }
    }
}
