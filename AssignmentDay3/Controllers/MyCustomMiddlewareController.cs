using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AssignmentDay3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MyCustomMiddlewareController : ControllerBase
    {
        private readonly ILogger<LoggingMessageWriter> _logger;
        public MyCustomMiddlewareController(ILogger<LoggingMessageWriter> logger)
        {
            _logger = logger;
        }
        [HttpGet("GetContextInfo")]
        public IActionResult GetContextInfo(string name,int age)
        {
            return Ok(200);
        }
    }
}
