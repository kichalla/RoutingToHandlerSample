using Microsoft.AspNetCore.Mvc;
using System;

namespace RoutingToHandlerSample.Controllers
{
    public class CustomersController : Controller
    {
        public IActionResult Index()
        {
            //return Content("Hello, World!");
            throw new InvalidOperationException("Error in Customers.Index");
        }
    }
}