using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System.IO;
using Microsoft.Extensions.DependencyInjection;
using static System.Environment;
using static System.Reflection.Assembly;

namespace Spike.Api
{
    public static class Program
    {
        static Program() => CurrentDirectory = Path.GetDirectoryName(GetEntryAssembly().Location);

        public static void Main(string[] args)
        {
            var configuration = BuildConfiguration(args);
            ConfigureWebHost(configuration).Build().Run();
        }

        private static IConfiguration BuildConfiguration(string[] args)
            => new ConfigurationBuilder()
            .SetBasePath(CurrentDirectory)
            .Build();
        private static IWebHostBuilder ConfigureWebHost(IConfiguration configuration)
            => new WebHostBuilder().UseStartup<Startup>()
            .UseConfiguration(configuration)
            .ConfigureServices(services =>
            services.AddSingleton(configuration))
            .UseContentRoot(CurrentDirectory)
            .UseKestrel();

    }
}
