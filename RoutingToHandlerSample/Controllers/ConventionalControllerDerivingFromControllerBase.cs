using Microsoft.AspNetCore.Mvc;

namespace RoutingToHandlerSample.Controllers
{
    public class ConventionalControllerDerivingFromControllerBase : ControllerBase
    {
        //[CustomAuthFilter]
        public IActionResult Index()
        {
            return Content("Hello, World!");
            //throw new InvalidOperationException("Error in Customers.Index");
        }
    }
}
