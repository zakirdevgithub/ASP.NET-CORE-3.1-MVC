using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

//1.asp-controller
//2.asp-action
//3.asp-route-id for id parameter
//4.asp-route-title for title parameter
//5.asp-all-route-data for dictionary
//6.asp-protocol
//7.asp-host
//8.[Route(" ", Name =)] for custom query string
//9.asp-route for replace asp-controller and asp-action
//10.asp-fragment


namespace Q_Anchor_Tag_Helper
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }
           public static IHostBuilder CreateHostBuilder(string[] args)=>
       
            Host.CreateDefaultBuilder(args).ConfigureWebHostDefaults(webBuilder =>
            {
                webBuilder.UseStartup<Startup>();
            });
       
    }
}
