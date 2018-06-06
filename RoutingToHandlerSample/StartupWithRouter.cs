using System.Text;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;

namespace RoutingToHandlerSample
{
    public class StartupWithRouter
    {
        private static readonly byte[] _helloWorldPayload = Encoding.UTF8.GetBytes("Hello, World!");
        
        public void ConfigureServices(IServiceCollection services)
        {
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseRouter(routes =>
            {
                routes.MapRoute("/", (httpContext) =>
                {
                    var response = httpContext.Response;
                    var payloadLength = _helloWorldPayload.Length;
                    response.StatusCode = 200;
                    response.ContentType = "text/plain";
                    response.ContentLength = payloadLength;
                    return response.Body.WriteAsync(_helloWorldPayload, 0, payloadLength);
                });
            });
        }
    }
}
