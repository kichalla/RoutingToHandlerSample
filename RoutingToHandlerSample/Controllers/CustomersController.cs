using Microsoft.AspNetCore.Mvc;
using System;

namespace RoutingToHandlerSample.Controllers
{
    public class CustomersController : Controller
    {
        public IActionResult Index()
        {
            throw new InvalidOperationException("Error in Customers.Index");
        }
    }
}