using Hectre.HarvestManagement.Core.Models;
using Hectre.HarvestManagement.Core.Services;
using Hectre.HarvestManagement.WebAPI.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Hectre.HarvestManagement.WebAPI.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/v1/[controller]")]
    public class HarvestController: ControllerBase
    {
        private readonly ILogger<HarvestController> _logger;
        private readonly IHarvestService _harvestService;

        public HarvestController(ILogger<HarvestController> logger, IHarvestService harvestService)
        {
            _logger = logger;
            _harvestService = harvestService;
        }

        [HttpGet]
        [Route("")]
        public async Task<IList<Harvest>> GetHarvest([FromQuery] Guid[] orchardIds, DateTime? start, DateTime? end)
        {
            return await _harvestService.FindRecords(orchardIds, start, end);
        }

        [HttpPost]
        [Route("")]
        public async Task<IActionResult> AddHarvests([FromBody] Harvest harvestRecord)
        {
            await _harvestService.AddHarvestRecordAsync(harvestRecord);
            return Ok();
        }

        [HttpPost]
        [Route("AssignTimeSheet")]
        public async Task<IActionResult> AssignTimeSheet([FromBody] TimeSheetHarvestRelation assignTimeSheetRequest)
        {
            await _harvestService.AssignTimeSheet(assignTimeSheetRequest);
            return Ok();
        }
	}
}

