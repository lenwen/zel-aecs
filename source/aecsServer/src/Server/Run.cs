using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using data = Aecs.Settings.Data;
namespace Aecs.Server
{


    public class Run
    {
        public void Start()
        {
            //TODO  check if init file exist.



            data.NodeId = 22;
            data.TestValue1 = "test";
            Console.WriteLine("nice");
            Console.ReadLine();

        }
    }
}
