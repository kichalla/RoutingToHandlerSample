using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Abstractions;
using System.Threading.Tasks;

namespace RoutingToHandlerSample.Internal
{
    public class CustomActionInvoker : IActionInvoker
    {
        private readonly ActionContext _actionContext;

        public CustomActionInvoker(ActionContext actionContext)
        {
            _actionContext = actionContext;
        }

        public Task InvokeAsync()
        {
            _actionContext.HttpContext.Response.StatusCode = StatusCodes.Status200OK;
            return _actionContext.HttpContext.Response.WriteAsync("Hello, World!");
        }
    }
}
