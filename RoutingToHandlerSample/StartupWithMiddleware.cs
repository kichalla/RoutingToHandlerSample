using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System.Threading.Tasks;

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
