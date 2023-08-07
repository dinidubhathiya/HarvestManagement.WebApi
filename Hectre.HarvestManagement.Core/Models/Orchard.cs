using System.ComponentModel.DataAnnotations;

namespace Hectre.HarvestManagement.Core.Models
{
    public class Orchard
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int Block { get; set; }
        [Required]
        public string SubBlock { get; set; }
    }
}