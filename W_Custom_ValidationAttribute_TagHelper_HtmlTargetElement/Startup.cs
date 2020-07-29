﻿using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using W_Custom_ValidationAttribute_TagHelper_HtmlTargetElement.Data;
using W_Custom_ValidationAttribute_TagHelper_HtmlTargetElement.Station;

namespace W_Custom_ValidationAttribute_TagHelper_HtmlTargetElement
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
#if DEBUG
            services.AddRazorPages().AddRazorRuntimeCompilation();
#endif
            services.AddControllersWithViews();
            services.AddDbContext<DataContext>(options => options.UseSqlServer
            ("Server=DESKTOP-E7O9U9N; Database=MyValidation;" +
            " Trusted_Connection=True; MultipleActiveResultSets=True;"));

            services.AddScoped<BookStation, BookStation>();
            services.AddScoped<LanguageStation, LanguageStation>();

        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            //app.Use(async(context, next) =>
            //{
            //    await context.Response.WriteAsync("This is First Middleware ");
            //    await next();
            //});
            //app.Use(async(context, next) =>
            //{
            //    await context.Response.WriteAsync("This is Second Middleware ");
            //    await next();
            //});
            app.UseStaticFiles();
            app.UseStaticFiles(new StaticFileOptions()
            {
                FileProvider=new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(),"ExtraImages")),
                RequestPath="/ExtraImages"
            });
            app.UseRouting();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapDefaultControllerRoute();
            });
        }
    }
}