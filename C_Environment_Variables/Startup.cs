using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace C_Environment_Variables
{
    public class Startup
    {
        public void ConfigurationServices(IServiceCollection service)
        {

        }
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if(env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }


            app.UseRouting();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/", async context =>
                {
                    if(env.IsDevelopment())
                    {
                        await context.Response.WriteAsync("Development Environment");
                    }
                    else if(env.IsProduction())
                    {
                        await context.Response.WriteAsync("Production Environment");
                    }
                    else if(env.IsStaging())
                    {
                        await context.Response.WriteAsync("Staging Environment");
                    }
                    else
                    {
                        await context.Response.WriteAsync(env.EnvironmentName);
                    }
                   
                });
            });


        }
    }
}
