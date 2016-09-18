using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aecs.Server.Interfaces.Functions
{
    interface IpowerRelay
    {
        Aecs.Models.Config.PowerRelayModel Settings { get; set; }

        bool IsOn { get; set; }

        void TurnOn();

        void TurnOff();


    }
}
