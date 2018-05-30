using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace RoutingToHandlerSample.Controllers
{
    public class ConventionalControllerDerivingFromControllerBase : ControllerBase
    {
        ////[CustomAuthFilter]
        //public IActionResult Index()
        //{
        //    return Content("Hello, World!");
        //    //throw new InvalidOperationException("Error in Customers.Index");
        //}

        public Task Index()
        {
            HttpContext.Response.StatusCode = StatusCodes.Status200OK;

            return HttpContext.Response.WriteAsync("Hello, World!");
        }
    }
}
