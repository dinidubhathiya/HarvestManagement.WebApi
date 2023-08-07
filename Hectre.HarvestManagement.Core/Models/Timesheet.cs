using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hectre.HarvestManagement.Core.Models
{
    public class Timesheet
	{
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        [Required]
        public string SupervisorId { get; set; }
        [Required]
        public string PickerId { get; set; }
        [Required]
        public DateTime StartTime { get; set; }
        [Required]
        public DateTime EndTime { get; set; }
        [Required]
        public string Activity { get; set; }
        [Required]
        public Guid OrchardId { get; set; }
        [Required]
        public Orchard Orchard { get; set; }
    }
}

