using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using settings = Aecs.Settings;
namespace Aecs.Server
{


    public class Run
    {
        public void Start()
        {
            //TODO  check if init file exist.



            settings.NodeId = 22;
            settings.TestValue1 = "test";
            Console.WriteLine("nice");
            Console.ReadLine();

        }
    }
}
