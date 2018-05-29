using Microsoft.AspNetCore.Mvc;
using System;

namespace RoutingToHandlerSample.Controllers
{
    public class HomeController : Controller
    {
        [Route("/home/index")]
        public IActionResult Index()
        {
            //return Content("Hello, World!");
            throw new InvalidOperationException("Error in Customers.Index");
        }
    }
}
