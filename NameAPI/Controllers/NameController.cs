using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace NameAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NameController : ControllerBase
    {

        private readonly ILogger<NameController> _logger;

        public NameController(ILogger<NameController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var personName = new Name { PersonName = "Nathan Burns" };
            return Ok(personName);
        }
    }
}