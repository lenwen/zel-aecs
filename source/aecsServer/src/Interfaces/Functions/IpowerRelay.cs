using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aecs.Interfaces.Functions
{
    public interface IpowerRelay
    {
        bool IsOn();

        void TurnOn();

        void TurnOff();




    }
}
