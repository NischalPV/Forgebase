using System;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Forgebase.Masterdata.Controllers
{
    [Authorize]
    [Route("api/v1/[controller]")]
    public class MasterdataController: Controller
    {
        private readonly ILogger<MasterdataController> _logger;

        public MasterdataController(ILogger<MasterdataController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return Ok();
        }
    }
}
