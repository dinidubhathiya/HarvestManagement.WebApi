using Hectre.HarvestManagement.Core.Models;

namespace Hectre.HarvestManagement.Core.Services
{
    public interface IOrchardService
	{
		public Task<IList<Orchard>> GetAllAsync();
	}
}

