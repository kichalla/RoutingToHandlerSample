using Microsoft.AspNetCore.Mvc;
using RoutingToHandlerSample.Internal;
using System;

namespace RoutingToHandlerSample.Controllers
{
    public class ConventionalRouteController : Controller
    {
        //[CustomAuthFilter]
        public IActionResult Index()
        {
            return Content("Hello, World!");
            //throw new InvalidOperationException("Error in Customers.Index");
        }
    }
}