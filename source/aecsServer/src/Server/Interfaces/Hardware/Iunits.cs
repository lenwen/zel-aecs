using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aecs.Server.Interfaces.Hardware
{
    public interface Iunits
    {
        bool IsEnable { get; set; }
        bool IsOnline { get; set; }
        int NodeInChargePrimary { get; set; }
        int NodeInChargeSecondary { get; set; }
        int ConnectedTo { get; set; }
        List<string> RelayConnected { get; set; }
        List<string> SensorsConnected { get; set; }

        void TurnOn(string RelayId, string PortId);
        Dictionary<string, string> RelayIdToUnitPortId { get; set; }

    }
}
