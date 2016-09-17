using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aecs
{
    public static class Settings
    {
        public static int NodeId { get; set; }
        public static Dictionary<int, Classes.NodeClass> NodesInCluser { get; set; }
        
        public static string TestValue1 { get; set; }
        public static string TestValue2 { get; set; }
        public static string TestValue3 { get; set; }
    }
}
