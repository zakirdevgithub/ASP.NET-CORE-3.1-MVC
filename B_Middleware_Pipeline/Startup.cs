using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace B_Middleware_Pipeline
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
                //Middleware
                app.UseDeveloperExceptionPage();

            }
            //Middleware
            app.Use(async (context, next) =>
            {
                await context.Response.WriteAsync("Hello From First Middleware ");
                await next();
                await context.Response.WriteAsync(" Hello From First Response ");
            });
            //Middleware
            app.Use(async (context,next)=> 
            {
                await context.Response.WriteAsync(" Hello From Second Middleware ");
                await next();
                await context.Response.WriteAsync(" Hello From Second Response ");
            });
            //Middleware
            app.Use(async (context, next) => 
            {
                await context.Response.WriteAsync(" Hello From Third Middleware ");
                await next();
            });
            //Middleware
            ////UseRouting Middleware basically map a URL to a particular resources
            app.UseRouting();

            //Middleware
            //It indicate the EndPoint 
            app.UseEndpoints(endpoints =>
            {
            endpoints.MapGet("/", async context=>{

                //Particular Resources
                await context.Response.WriteAsync("Hello World!");
               });
            });

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/zakir", async context =>
                {
                   await context.Response.WriteAsync("Hello Zakir!");
                });
            });

        }
    }
}
