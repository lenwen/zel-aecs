using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;

namespace AecsIoT
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Starting software");



            var host = new WebHostBuilder()
                .UseKestrel()
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseIISIntegration()
                .UseStartup<Startup>()
                .Build();

            host.Run();
        }
    }

    public static class Settings
    {
        public static Dictionary<string, ClientDataClass> Clients { get; set; }

    }
    public class ClientDataClass
    {
        public UInt64 Id { get; set; }

    }
}
