using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RoutingToHandlerSample.Internal;
using System;
using System.Threading.Tasks;

namespace RoutingToHandlerSample.Controllers
{
    public class AttributeRouteController : Controller
    {
        ////[CustomAuthFilter]
        //[Route("/attributeroute/index")]
        //public IActionResult Index()
        //{
        //    return Content("Hello, World!");
        //    //throw new InvalidOperationException("Error in Customers.Index");
        //}

        [Route("/attributeroute/index")]
        public Task Index()
        {
            HttpContext.Response.StatusCode = StatusCodes.Status200OK;

            return HttpContext.Response.WriteAsync("Hello, World!");
        }
    }
}
