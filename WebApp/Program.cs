using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore;
using System.IO;

namespace WebApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();

        //public static IWebHost CreateWebHostBuilder(string[] args) =>
        //  WebHost.CreateDefaultBuilder(args)
        //    .UseStartup<Startup>()
        ////    .Build();
        //public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
        //  WebHost.CreateDefaultBuilder(args)

        //     .ConfigureLogging(logBuilder =>
        //     {
        //         logBuilder.ClearProviders(); // removes all providers from LoggerFactory
        //         logBuilder.AddConsole();
        //         logBuilder.AddTraceSource("Information, ActivityTracing"); // Add Trace listener provider
        //     })

        //     // .UseUrls(new string[] { "https://*:5000", "https://*:5001", "https://*:5002", "https://*:5003" })
        //      .UseStartup<Startup>()
        //      .UseContentRoot(Directory.GetCurrentDirectory())
        //      .UseDefaultServiceProvider((context, options) =>
        //      {
        //          options.ValidateScopes = context.HostingEnvironment.IsDevelopment();
        //      });
    }
}
