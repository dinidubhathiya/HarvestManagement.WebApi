using Hectre.HarvestManagement.Core.Models;
using Hectre.HarvestManagement.WebAPI.Models;

namespace Hectre.HarvestManagement.Core.Services
{
    public interface IHarvestService
	{
		public Task AddHarvestRecordAsync(Harvest input);
		public Task<IList<Harvest>> FindRecords(IList<Guid>? orchardId, DateTime? start, DateTime? end);
		public Task AssignTimeSheet(IList<TimeSheetHarvestRelation> timeSheetHarvestRelation);


    }
}

