using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aecs.Server.Interfaces.Functions;

namespace Aecs.Server.Classes
{
    public class PowerRelayClass : Interfaces.Functions.IpowerRelay
    {
        public int Id { get; set; }

        public bool IsOn()
        {
            throw new NotImplementedException();
        }

        public void TurnOff()
        {
            throw new NotImplementedException();
        }

        public void TurnOn()
        {
            throw new NotImplementedException();
        }

        int IpowerRelay.Id()
        {
            throw new NotImplementedException();
        }
    }
}
