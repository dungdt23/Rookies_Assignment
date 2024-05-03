using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace AssignmentDay3.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CustomMiddlewareController : ControllerBase
    {
        [HttpPost]
        public IActionResult Post(int id, [FromBody] RequestBodyModel requestBody)
        {
            if (string.IsNullOrEmpty(requestBody.Name)) return BadRequest("Request Body Name is invalid!");
            if (requestBody.Age < 0) return BadRequest("Request Body Age is invalid!");
            return Ok("Request is valid!");
        }
        public class RequestBodyModel
        {
            public required string Name { get; set; }
            public int Age { get; set; }
        }
    }
}
