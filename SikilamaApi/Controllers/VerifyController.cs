using Microsoft.AspNetCore.Mvc;

namespace SikilamaApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VerifyController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var response = new
            {
                builder = "Samson Ikilama",
                runner = Environment.GetEnvironmentVariable("RUN_BY") ?? "",
                timestamp = DateTime.UtcNow,
                machineName = Environment.MachineName
            };

            return Ok(response);
        }
    }
}

