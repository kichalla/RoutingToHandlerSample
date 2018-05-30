using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;
using System.Threading.Tasks;

namespace RoutingToHandlerSample
{
    public class StartupWithRouter
    {
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
                    response.StatusCode = StatusCodes.Status200OK;
                    return response.WriteAsync("Hello, World!");
                });
            });
        }
    }
}
