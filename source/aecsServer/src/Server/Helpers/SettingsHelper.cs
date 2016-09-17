using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Aecs.Server.Helpers
{
    public class SettingsHelper
    {
        // https://docs.asp.net/en/latest/fundamentals/configuration.html
        // https://blog.jsinh.in/asp-net-5-configuration-microsoft-framework-configurationmodel/#.V91FTSiLRaQ

        private IConfigurationBuilder configFile { get; set; }
        private IConfigurationRoot configRoot { get; set; }
        public bool configFileExist { get; set; }

        public SettingsHelper()
        {
            var ddsf = "sdfsdf";
            this.configFile = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("aecssettings.json");

            this.configFileExist = false;

            try
            {
                this.configRoot = this.configFile.Build();
                this.configFileExist = true;
            }
            catch
            {
                this.configFileExist = false;
            }

        }
        public void ReadSettingsFromFile()
        {
            var ddsf = "sdfsdf";
            //this.configFile = new ConfigurationBuilder()
            //    .SetBasePath(Directory.GetCurrentDirectory())
            //    .AddJsonFile("aecssettings.json");
            //ddsf = "sdfsdf";

            //this.configRoot = this.configFile.Build();

            //var dd = this.configFile.Build();
            ddsf = "sdfsdf";
            var asd = this.configRoot["ddd"];
            ddsf = "sdfsdf";
            // work with with a builder using multiple calls
            //var builder = new ConfigurationBuilder();
            //builder.SetBasePath(Directory.GetCurrentDirectory());
            //builder.AddJsonFile("aecssettings.json");
            //var connectionStringConfig = builder.Build();

            //// chain calls together as a fluent API
            //var config = new ConfigurationBuilder()
            //    .SetBasePath(Directory.GetCurrentDirectory())
            //    .AddJsonFile("aecssettings.json").Build();
            //.AddEntityFrameworkConfig(options =>
            //    options.UseSqlServer(connectionStringConfig.GetConnectionString("DefaultConnection"))
            //)
            //.Build();
            ddsf = "sdfsdf";

            //Console.WriteLine("key1={0}", config["key1"]);
            //Console.WriteLine("key2={0}", config["key2"]);
            //Console.WriteLine("key3={0}", config["key3"]);
            ddsf = "sdfsdf";

        }

        public void ConfigureServices(IServiceCollection services)
        {
            // http://developer.telerik.com/featured/new-configuration-model-asp-net-core/
            var builder = new ConfigurationBuilder()
            .AddJsonFile("appsettings.json")
            .AddEnvironmentVariables();
            var Configuration = builder.Build();

            var dsfdsf = (Configuration.GetSection("Smtp"));

            // services.Configure<Models.NodeStartupConnect>(Configuration.GetSection("Smtp"));
            // services.AddMvc();
            //Other services
        }
        public void ConfigureServicesxxxxxxxxxxxx(IServiceCollection services)
        {
            //services.Configure<SmtpConfig>(Configuration.GetSection("Smtp"));
            //services.AddMvc();
            //Other services
        }


        public void Test()
        {
            // work with with a builder using multiple calls
            var builder = new ConfigurationBuilder();
            builder.SetBasePath(Directory.GetCurrentDirectory());
            builder.AddJsonFile("appsettings.json");
            var connectionStringConfig = builder.Build();

            // chain calls together as a fluent API
            //var config = new ConfigurationBuilder()
            //    .SetBasePath(Directory.GetCurrentDirectory())
            //    .AddJsonFile("appsettings.json")
            //    .AddEntityFrameworkConfig(options =>
            //        options.UseSqlServer(connectionStringConfig.GetConnectionString("DefaultConnection"))
            //    )
            //    .Build();

            //Console.WriteLine("key1={0}", config["key1"]);
            //Console.WriteLine("key2={0}", config["key2"]);
            //Console.WriteLine("key3={0}", config["key3"]);
        }

    }
}
