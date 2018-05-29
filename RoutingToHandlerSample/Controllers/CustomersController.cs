using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RoutingToHandlerSample.Controllers
{
    public class CustomersController : Controller
    {
        public IActionResult Index()
        {
            return StatusCode(StatusCodes.Status200OK);
        }
    }
}