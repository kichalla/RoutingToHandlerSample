using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;

namespace RoutingToHandlerSample.Internal
{
    public class CustomAuthFilterAttribute : Attribute, IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            context.Result = new ContentResult()
            {
                Content = "Hello, World!",
                StatusCode = StatusCodes.Status200OK
            };
        }
    }
}
