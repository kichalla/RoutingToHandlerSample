using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RoutingToHandlerSample.Controllers
{
    public class HomeController : Controller
    {
        [Route("/home/index")]
        public IActionResult Index()
        {
            return Content("Hello, World!");
        }
    }
}
