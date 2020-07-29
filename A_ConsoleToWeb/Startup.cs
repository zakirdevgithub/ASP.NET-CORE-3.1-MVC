using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace A_ConsoleToWeb
{
    public class Startup
    {
        public void ConfigurationServices(IServiceCollection service)
        {

        }
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            //UseRouting Middleware basically map a URL to a particular resources
            app.UseRouting();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/", async context =>
                {
                    //Particular Resources
                    await context.Response.WriteAsync("I convert Console App to Web App Successfully");
                });
            });
        }
    }
}
