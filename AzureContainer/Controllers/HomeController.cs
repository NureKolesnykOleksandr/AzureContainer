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
            return "Hello cloud world!";
        }
    }
}
