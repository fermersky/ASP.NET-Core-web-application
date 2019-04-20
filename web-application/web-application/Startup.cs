using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace web_application
{
    public class Startup
    {
        private IConfiguration _config;

        public Startup(IConfiguration config)
        {
            // settings in appsettings.Development overrides the settings in appsettings.json
            _config = config;
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILogger<Startup> logger) // this method processes a request
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            // Run method doesn't call next middleware. It's a terminal middleware
            // Use method recieves 2 parameters: context and next middleware function

            /* app.Run(async (context) =>
            {
                // await context.Response.WriteAsync(_config["MyKey"]); // from appsettings.json

                await context.Response.WriteAsync("Hello World!");
            }); */

            // Everything that happens BEFORE next() is a REQUEST and it travels from MW to MW
            // Everything that happens AFTER next() is a RESPONCE and it travels from MW to MW

            app.Use(async (context, next) =>
            {
                //await context.Response.WriteAsync("Hello World!");
                logger.LogInformation("MW1: Incoming request"); // print in console
                await next();
                logger.LogInformation("MW1: Outcoming request");
            });

            app.Use(async (context, next) =>
            {
                //await context.Response.WriteAsync("Hello World!");
                logger.LogInformation("MW2: Incoming request");
                await next();
                logger.LogInformation("MW2: Outcoming request");
            });

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("MW3: Final middleware");
            });
        }
    }
}
