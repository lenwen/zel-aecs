using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aecs.Models.Config;
using Aecs.Server.Interfaces.Functions;

namespace Aecs.Server.Classes
{
    public class PowerRelayClass : Interfaces.Functions.IpowerRelay
    {
        
        public PowerRelayModel Settings { get; set; }

        public bool IsOn { get; set; }

        public void TurnOff()
        {
            throw new NotImplementedException();
        }

        public void TurnOn()
        {
            throw new NotImplementedException();
        }

    }
}
