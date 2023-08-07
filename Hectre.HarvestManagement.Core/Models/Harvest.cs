using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hectre.HarvestManagement.Core.Models
{
    public class Harvest
	{
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        [Required]
        public string SupervisorId { get; set; }
        [Required]
        public string PickerId { get; set; }
        [Required]
        public DateTime PickingDate { get; set; }
        [Required]
        public string Type { get; set; }
        [Required]
        public long BinCount { get; set; }
        [Required]
        public float HourlyWageRate { get; set; }
        [Required]
        public float HoursWorked { get; set; }
        [Required]
        public string Variety { get; set; }
        [Required]
        public Guid OrchardId { get; set; }
        public Orchard Orchard { get; set; }
    }
}

