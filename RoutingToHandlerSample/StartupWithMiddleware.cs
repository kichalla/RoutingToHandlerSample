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
            app.Run(httpContext =>
            {
                // 1. accessing path was expensive
                var path = httpContext.Request.Path;

                // 2. setting feature was expensive
                httpContext.Features.Set<ITestFeature>(new TestFeature());

                var response = httpContext.Response;
                response.StatusCode = StatusCodes.Status200OK;
                return response.WriteAsync("Hello, World!");
            });

            //app.Map("/middleware", (subApp) =>
            //{
            //    subApp.Run(httpContext =>
            //    {

            //        var response = httpContext.Response;
            //        response.StatusCode = StatusCodes.Status200OK;
            //        return response.WriteAsync("Hello, World!");
            //    });
            //});
        }
    }

    public interface ITestFeature
    {
        int MyProperty { get; set; }
    }

    public class TestFeature : ITestFeature
    {
        public int MyProperty { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
    }
}
