using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//using Microsoft.AspNetCore.Owin;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System.IO;


// https://jonhilton.net/2016/07/18/your-first-net-core-web-application-using-nothing-but-the-command-line/

//  Angular 2  .net core
//  https://jonhilton.net/2016/12/13/angular-2-and-net-core-your-first-component/


namespace Aecs.Server.OwinWebServer
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
        }

        public void Configure(IApplicationBuilder app)
        {
            app.UseMvc();


            app.Run(context =>
            {
                return context.Response.WriteAsync("Hello world");
            });
        }
    }

    public static class Program
    {
        public static void Main()
        {
            Console.WriteLine("Hello World!");

            var host = new WebHostBuilder()
            .UseKestrel()
            // .UseContentRoot(Directory.GetCurrentDirectory() + @"\function\webserver")
            .UseContentRoot(GetFolderToViews())
            .UseStartup<Startup>()
            .Build();

            host.Run();
        }

        private static string GetFolderToViews()
        {
            return @"C:\Users\lennie\Source\Repos\zel-aecs\source\aecsServer\src\Server\Function\Webserver";
        }
    }
    // C:\Users\lennie\Source\Repos\zel-aecs\source\aecsServer\src\Server\Function\Webserver

}
