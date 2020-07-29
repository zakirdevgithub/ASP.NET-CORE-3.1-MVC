using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using System;


//-----------UPDATE CSPROJ FILE--------
//1.change Project SDK to Web
//2.remove OutputType

//------------Create Hostbuilder in Program class------
//1.Make a HostBuilder Method and which return Type is IHostBuilder
//2.Use CreateDefaultBilder and ConfigureWebHostDefaults from Host class

//----------- Startup Class ----------
//1.Make tow Method ConfigurationServices and Configure
//2. Add Middlewared in Configure Method


namespace A_ConsoleToWeb
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
