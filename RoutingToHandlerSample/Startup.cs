using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.Extensions.DependencyInjection;
using RoutingToHandlerSample.Internal;

namespace RoutingToHandlerSample
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvcCore();

            //services.AddMvcCore(o =>
            //{
            //    o.Filters.Clear();
            //});

            // Only enable for convetional routing
            // services.AddSingleton<IActionDescriptorCollectionProvider, CustomActionDescriptorCollectionProvider>();

            // Enable for both conventional and attribute routing
            services.AddSingleton<IActionInvokerFactory, CustomActionInvokerFactory>();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseMvcWithDefaultRoute();
        }
    }
}
