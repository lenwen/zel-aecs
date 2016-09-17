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
            //TODO  check if init file exist.
                       
            
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
