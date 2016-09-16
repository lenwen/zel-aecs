using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleStarter
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var starter = new Aecs.Server.Run();
            starter.Start();

        }
    }
}
