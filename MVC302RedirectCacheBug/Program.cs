using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace MVC302RedirectCacheBug
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var config = new ConfigurationBuilder()
                .AddCommandLine(args)
                .SetBasePath(System.AppContext.BaseDirectory)
                .AddEnvironmentVariables(prefix: "ASPNETCORE_")
                .Build();
            var application = new WebHostBuilder()
                .UseConfiguration(config)
                .UseIISIntegration()
                .UseHttpSys()
                .UseUrls("http://localhost:5000")
                .UseStartup<Startup>()
                .Build();
            application.Run();
        }
    }
}
