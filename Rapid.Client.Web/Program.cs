using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace Rapid.Client.Web {
    public class Program {
        public static void Main(string[] args) {
            BuildWebHost(args).Run();
        }

        public static IWebHost BuildWebHost(string[] args)
        {
            return WebHost.CreateDefaultBuilder()
                .ConfigureAppConfiguration((ctx, cfg) =>
                {
                    cfg.SetBasePath(Directory.GetCurrentDirectory())
                        .AddJsonFile("config.json", true) // require the json file!
                        .AddEnvironmentVariables();
                })
                .ConfigureLogging((ctx, logging) => { }) // No logging
                .UseStartup<Startup>()
                .UseSetting("DesignTime", "true")
                .Build();
        }

        //public static IWebHost BuildWebHost(string[] args) =>
        //    WebHost.CreateDefaultBuilder(args)
        //        .UseStartup<Startup>()
        //        .Build();

        //public static IWebHost BuildWebHost(string[] args)
        //{
        //    //return WebHost.CreateDefaultBuilder()
        //    //    .ConfigureAppConfiguration(ConfigConfiguration)
        //    //    .ConfigureLogging(ConfigureLogger)
        //    //    .UseStartup<Startup>()
        //    //    .Build();
        //    return new WebHostBuilder()
        //        .UseKestrel()
        //        .UseContentRoot(Directory.GetCurrentDirectory())
        //        .ConfigureAppConfiguration((hostingContext, config) =>
        //        {
        //            var env = hostingContext.HostingEnvironment;

        //            config.AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
        //                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true, reloadOnChange: true);

        //            if (env.IsDevelopment())
        //            {
        //                var appAssembly = Assembly.Load(new AssemblyName(env.ApplicationName));
        //                if (appAssembly != null)
        //                {
        //                    config.AddUserSecrets(appAssembly, optional: true);
        //                }
        //            }

        //            config.AddEnvironmentVariables();

        //            if (args != null)
        //            {
        //                config.AddCommandLine(args);
        //            }
        //        })
        //        .ConfigureLogging((hostingContext, logging) =>
        //        {
        //            logging.AddConfiguration(hostingContext.Configuration.GetSection("Logging"));
        //            logging.AddConsole();
        //            logging.AddDebug();
        //        })
        //        //.UseIISIntegration()
        //        .UseDefaultServiceProvider((context, options) =>
        //        {
        //            options.ValidateScopes = context.HostingEnvironment.IsDevelopment();
        //        })
        //        .UseStartup<Startup>()
        //        .Build();
        //}

        //static void ConfigConfiguration(WebHostBuilderContext ctx, IConfigurationBuilder config)
        //{
        //    config.SetBasePath(Directory.GetCurrentDirectory())
        //        .AddJsonFile("config.json", false, true)
        //        .AddXmlFile("settings.xml", true)
        //        .AddEnvironmentVariables();

        //}

        //static void ConfigureLogger(WebHostBuilderContext ctx, ILoggingBuilder logging)
        //{
        //    logging.AddConfiguration(ctx.Configuration.GetSection("Logging"));
        //    logging.AddConsole();
        //    logging.AddDebug();
        //}
    }
}