using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace web_application
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // asp.net core application initialy starts as a Console Application
            // entry point
            CreateWebHostBuilder(args).Build().Run(); // create abd run IWebHost
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args) // creates a web-host (IWebHost is a object where application is deploying)
                .UseStartup<Startup>(); // class in <> is a start class, where http-request processes
    }
}
