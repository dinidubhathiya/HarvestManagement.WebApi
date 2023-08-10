using System;
using System.ComponentModel.DataAnnotations;

namespace Hectre.HarvestManagement.WebAPI.Models
{
	public class TimeSheetHarvestRelation
	{
        [Required]
        public Guid TimeSheetId { get; set; }
        [Required]
        public Guid HarvestId { get; set; }
    }
}

