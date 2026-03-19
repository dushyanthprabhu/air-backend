using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace air_backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetUsers()
        {
            return Ok("User Found");
        }
    }
}
