using Hectre.HarvestManagement.Core.Interfaces;
using Hectre.HarvestManagement.Core.Models;
using Hectre.HarvestManagement.Core.Services;
using Microsoft.Extensions.Logging;

namespace Hectre.HarvestManagement.Services
{
    public class HarvestService : IHarvestService
    {
        private readonly ILogger<HarvestService> _logger;
        private readonly IUnitOfWork _unitOfWork;

        public HarvestService(ILogger<HarvestService> logger, IUnitOfWork unitOfWork)
        {
            _logger = logger;
            _unitOfWork = unitOfWork;
        }



        public async Task AddHarvestRecordAsync(Harvest input)
        {
            var  orchard = await _unitOfWork.OrchardRepository.GetByIDAsync(input.Orchard.Id);
            if(orchard != null)
            {
                input.Orchard = orchard;
            }
            await _unitOfWork.HarvestRepository.InsertAsync(input);
            await _unitOfWork.SaveAsync();
        }

        public async Task<IList<Harvest>> FindRecords(IList<Guid>? orchardIds, DateTime? start, DateTime? end)
        {
            var result =  await _unitOfWork.HarvestRepository.GetAsync( filter: (Harvest record) =>
            (orchardIds == null || orchardIds.Count == 0 || orchardIds.Contains(record.OrchardId)) &&
            (start == null || record.PickingDate >= start) &&
            (end == null || record.PickingDate <= end)

            ,
            includeProperties: "Orchard");
            return result.ToList();
        }
    }
}

