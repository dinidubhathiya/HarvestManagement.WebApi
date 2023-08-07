using Hectre.HarvestManagement.Core.Models;

namespace Hectre.HarvestManagement.Core.Services
{
    public interface IHarvestService
	{
		public Task AddHarvestRecordAsync(Harvest input);
		public Task<IList<Harvest>> FindRecords(IList<Guid>? orchardId, DateTime? start, DateTime? end);


    }
}

