using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Abstractions;
using System.Text;
using System.Threading.Tasks;

namespace RoutingToHandlerSample.Internal
{
    public class CustomActionInvoker : IActionInvoker
    {
        private static readonly byte[] _helloWorldPayload = Encoding.UTF8.GetBytes("Hello, World!");
        private readonly ActionContext _actionContext;

        public CustomActionInvoker(ActionContext actionContext)
        {
            _actionContext = actionContext;
        }

        public Task InvokeAsync()
        {
            var response = _actionContext.HttpContext.Response;
            var payloadLength = _helloWorldPayload.Length;
            response.StatusCode = 200;
            response.ContentType = "text/plain";
            response.ContentLength = payloadLength;
            return response.Body.WriteAsync(_helloWorldPayload, 0, payloadLength);
        }
    }
}
