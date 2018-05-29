using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Abstractions;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
