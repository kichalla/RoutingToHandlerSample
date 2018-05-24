using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;

namespace RoutingToHandlerSample
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRouting();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseRouter(routes =>
            {
                routes.MapRoute("", (httpContext) =>
                {
                    var response = httpContext.Response;
                    response.StatusCode = StatusCodes.Status200OK;
                    return response.WriteAsync("Hello, World!", httpContext.RequestAborted);
                });
            });
        }
    }
}
