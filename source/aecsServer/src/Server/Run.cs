using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace Aecs.Server
{


    public class Run
    {
        public void Start()
        {
            var dsfdsf = "sdfsdf";

            //TODO  check if init file exist.
            var settingsHelper = new Helpers.SettingsHelper();

            if (settingsHelper.configFileExist)
            {
                settingsHelper.ReadSettingsFromFile();
            }
            else
            {
                //TODO  config file dont exist.
                dsfdsf = "sdfsdf";
            }

            // settingsHelper.Savetest();

                       
            
            Settings.NodeId = 22;
            Settings.TestValue1 = "test";
            Console.WriteLine("nice");
            Console.ReadLine();

        }

        //public Startup(IHostingEnvironment env)
        //{
        //    var builder = new ConfigurationBuilder()
        //        .SetBasePath(env.ContentRootPath)
        //        .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
        //        .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
        //        .AddEnvironmentVariables();

        //    Configuration = builder.Build();
        //}



    }
}
