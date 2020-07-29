using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using System;


//----------Main Environment Variables Are--------
//    1.Development
//    2.Production
//    3.Staging
//Directory of Environment Variable is Properties>launchSettings.json


namespace C_Environment_Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string [] args)=>
        
            Host.CreateDefaultBuilder(args).ConfigureWebHostDefaults(webBuilder =>
            {
                webBuilder.UseStartup<Startup>();
            });
        
    }
}
