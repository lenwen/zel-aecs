using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

using System.Reflection;
using Emitter.Configuration;
using Emitter.Diagnostics;
using Emitter.Providers;
using Emitter.Security;
using Emitter.Storage;
using Emitter;

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
            // Console.WriteLine("nice");


            Console.WriteLine("Starting webserver");
            OwinWebServer.Program.Main();

            Console.WriteLine("is this running");



            Console.WriteLine("starting broker!!");
            //var dd = new Emitter.Program();
            //dd.Run();

            Console.WriteLine("starting broker!! - ENDING !!");


            //var mqttServer = new Emitter.Connection();
            //var emitter = new Emitter.Connection();
            //var connection = emitter.();

            // Creating a connection to emitter.io service.
            // var sdfdsfemitter = new Emitter.Connection();

            // var channelKey = "<channel key for 'chat' channel>";

            // var ddsfdsf = new ddd.Connection();

            // var dd = Emitter.Connection();


            Console.WriteLine("END-----");
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
