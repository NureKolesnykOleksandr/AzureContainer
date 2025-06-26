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
            return "Hello updated brand new cloud world BOOOOO!";
        }

        [HttpGet("Love")]
        public string GetLove()
        {
            return "Hello my Nastona!)";
        }
    }
}
