using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;

namespace AssignmentDay3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MyCustomMiddlewareController : ControllerBase
    {
        private readonly ILogger<LoggingMessageWriter> _logger;
        private readonly IMessageWriter _messageWriter;
        public MyCustomMiddlewareController(ILogger<LoggingMessageWriter> logger, IMessageWriter messageWriter)
        {
            _logger = logger;
            _messageWriter = messageWriter;
        }
        [HttpPost("GetLogHttpRequest")]
        public IActionResult GetContextInfo(int id, [FromBody] RequestBodyModel requestBody)
        {
            return Ok("Get log succesfully!");
        }
    }
    public class RequestBodyModel
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
