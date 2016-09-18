using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aecs.Server.Interfaces.Functions
{
    interface IpowerRelay
    {
        int Id();


        bool IsOn();

        void TurnOn();

        void TurnOff();


    }
}
