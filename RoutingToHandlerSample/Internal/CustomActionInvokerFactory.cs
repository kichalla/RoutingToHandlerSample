using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Abstractions;
using Microsoft.AspNetCore.Mvc.Infrastructure;

namespace RoutingToHandlerSample.Internal
{
    public class CustomActionInvokerFactory : IActionInvokerFactory
    {
        public IActionInvoker CreateInvoker(ActionContext actionContext)
        {
            return new CustomActionInvoker(actionContext);
        }
    }
}
