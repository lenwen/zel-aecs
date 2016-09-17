using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
    }
}
