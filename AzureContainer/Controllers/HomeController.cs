using Microsoft.AspNetCore.Mvc;

namespace AzureContainer.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "Hello updated brand new cloud world!";
        }

        [HttpGet("Love")]
        public string GetLove()
        {
            return "I want to spend my life with you)";
        }
    }
}
