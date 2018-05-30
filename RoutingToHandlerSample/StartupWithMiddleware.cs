using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.Extensions.DependencyInjection;
using RoutingToHandlerSample.Internal;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace RoutingToHandlerSample
{
    public class StartupWithMiddleware
    {
        public void ConfigureServices(IServiceCollection services)
        {
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.Map("/middleware", (subApp) =>
            {
                subApp.Run(httpContext =>
                {
                    httpContext.Response.StatusCode = StatusCodes.Status200OK;
                    return Task.CompletedTask;
                });
            });
        }
    }
}
