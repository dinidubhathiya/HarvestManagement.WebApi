using Hectre.HarvestManagement.Core.Interfaces;
using Hectre.HarvestManagement.Core.Models;
using Hectre.HarvestManagement.Core.Services;
using Microsoft.Extensions.Logging;

namespace Hectre.HarvestManagement.Services
{
    public class OrchardService: IOrchardService
	{
        private readonly ILogger<OrchardService> _logger;
        private readonly IUnitOfWork _unitOfWork;
        public OrchardService(IUnitOfWork unitOfWork , ILogger<OrchardService> logger)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
        }

        public async Task<IList<Orchard>> GetAllAsync()
        {
            return (await _unitOfWork.OrchardRepository.GetAsync()).ToList();
        }
    }
}

