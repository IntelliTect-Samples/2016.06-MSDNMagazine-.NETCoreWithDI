using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Hosting;
using Microsoft.AspNet.Http;
using Microsoft.Extensions.DependencyInjection;
using AspNetSampleWithDI;

namespace AspNeSampleWithDI
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<ISampleScopedService, SampleService>();
            services.AddScoped(provider =>
            {
                var SampleService = provider.GetService<ISampleService>();
                return new ScopedFactoryService
                {
                    SampleService = SampleService,
                };
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app)
        {
            app.UseIISPlatformHandler();

            app.Run(async (context) =>
            {
                string result = "0";
                result = context.RequestServices.GetRequiredService<ISampleScopedService>().SimpleMethod();
                await context.Response.WriteAsync($"Hello World! ({ result })");
            });
        }

        // Entry point for the application.
        public static void Main(string[] args)
        {
            WebApplication.Run<Startup>(args);
        }
    }
}
