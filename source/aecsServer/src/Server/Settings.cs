using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aecs.Server
{
    public static class Settings
    {
        public static int NodeId { get; set; }
        public static Dictionary<int, Helpers.NodeHelper> NodesInCluser { get; set; }
        public static Dictionary<int, Classes.PowerRelayClass> PowerRelay { get; set; }
        public static Dictionary<int, Interfaces.Hardware.Iunits> Units { get; set; }

        public static string TestValue1 { get; set; }
        public static string TestValue2 { get; set; }
        public static string TestValue3 { get; set; }

        
    }
}
