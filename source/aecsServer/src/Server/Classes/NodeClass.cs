﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aecs.Server.Classes
{
    public class NodeClass
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsDbConnected { get; set; }
        public bool IsDbAccess { get; set; }
    }
}
