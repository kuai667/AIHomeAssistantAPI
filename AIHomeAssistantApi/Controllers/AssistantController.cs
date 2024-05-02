using Microsoft.AspNetCore.Mvc;

namespace AIHomeAssistantApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AssistantController : ControllerBase
    {
        [HttpGet]
        public IActionResult MainAction()
        {
            return Ok("The API is working");
        }
    }
}
