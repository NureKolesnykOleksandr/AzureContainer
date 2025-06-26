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
            return "Hello my Nastona!) I love u so much. I always will be on your side my kitty, i will always help you";
        }
    }
}
