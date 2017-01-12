using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;

// https://docs.microsoft.com/en-us/aspnet/core/publishing/linuxproduction

namespace AecsIoT
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Starting software - Jippi");

            string hej = Environment.MachineName;
            Console.WriteLine("srv:{0}", hej);

            //string SrvWebPort = "5000";

            //string webId = "http://0.0.0.0:60531";

            //if (hej == "aecssrv1")
            //    webId = "http://0.0.0.0:80";




            var host = new WebHostBuilder()
                .UseKestrel()
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseIISIntegration()
                .UseStartup<Startup>()
                .Build();


            if (hej == "aecssrv1")
            {
           
                host = new WebHostBuilder()
                .UseKestrel()
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseIISIntegration()
                .UseStartup<Startup>()
                .UseUrls("http://0.0.0.0:80")
                .Build();

            }

            host.Run();
        }
    }

    public static class Settings
    {
        public static Dictionary<UInt64, ClientDataClass> Clients { get; set; }

    }
    public class ClientDataClass
    {
        public UInt64 Id { get; set; }

        public Dictionary<string, UserDataClass> Accounts { get; set; }


    }
    public class UserDataClass
    {
        public string Password { get; set; }
        public bool IsSuperUser { get; set; }

    }
}
