using Microsoft.AspNetCore.Mvc;
using RoutingToHandlerSample.Internal;
using System;

namespace RoutingToHandlerSample.Controllers
{
    public class AttributeRouteControllerDerivingFromControllerBase : ControllerBase
    {
        //[CustomAuthFilter]
        [Route("/AttributeRouteControllerDerivingFromControllerBase/index")]
        public IActionResult Index()
        {
            return Content("Hello, World!");
            //throw new InvalidOperationException("Error in Customers.Index");
        }
    }
}
