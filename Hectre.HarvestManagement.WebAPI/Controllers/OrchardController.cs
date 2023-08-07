using Hectre.HarvestManagement.Core.Models;
using Hectre.HarvestManagement.Core.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Hectre.HarvestManagement.WebAPI.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/v1/[controller]")]
    public class OrchardController
	{
        private readonly ILogger<OrchardController> _logger;
        private readonly IOrchardService _orchardService;

        public OrchardController(ILogger<OrchardController> logger, IOrchardService orchardService)
        {
            _logger = logger;
            _orchardService = orchardService;
        }

        [HttpGet]
        [Route("all")]
        public async Task<IList<Orchard>> GetOrchards()
        {
            return await _orchardService.GetAllAsync();
        }

    }
}

