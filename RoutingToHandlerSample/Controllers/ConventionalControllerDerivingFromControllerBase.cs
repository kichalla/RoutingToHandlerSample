using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RoutingToHandlerSample.Internal;
using System.Threading.Tasks;

namespace RoutingToHandlerSample.Controllers
{
    public class ConventionalControllerDerivingFromControllerBase : ControllerBase
    {
        [CustomAuthFilter]
        public IActionResult Index()
        {
            return Content("Hello, World!");
            //throw new InvalidOperationException("Error in Customers.Index");
        }

        //public Task Index()
        //{
        //    HttpContext.Response.StatusCode = StatusCodes.Status200OK;

        //    return HttpContext.Response.WriteAsync("Hello, World!");
        //}

        //public IActionResult Index()
        //{
        //    return StatusCode(StatusCodes.Status200OK);
        //}

        //public Task Index()
        //{
        //    return Task.CompletedTask;
        //}
    }
}
