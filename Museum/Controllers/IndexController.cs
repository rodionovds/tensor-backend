using Microsoft.AspNetCore.Mvc;

namespace Museum.Controllers
{
    [Route("v1/")]
    [ApiController]
    public class IndexController : ControllerBase
    {
        [ApiVersion("1.0")]
        [HttpGet]
        public ActionResult Index()
        {
            return Ok("Welcome");
        }
    }
}