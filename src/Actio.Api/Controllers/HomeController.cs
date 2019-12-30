using Microsoft.AspNetCore.Mvc;

namespace Actio.Api.Controllers
{
    [Route("")]
    public class HomeController : Controller
    {
        public IActionResult Get() => Content("Hello from API");
    }
}