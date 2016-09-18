using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//  http://www.embeddeddatasystems.com/OW-SERVER-1-Wire-to-Ethernet-Server-Revision-2_p_152.html


namespace Aecs.Server.HardwareUnits
{
    public class OwServer : Interfaces.Hardware.Iunits
    {
        public int ConnectedTo { get; set; }

        public bool IsEnable { get; set; }
        public bool IsOnline { get; set; }

        public int NodeInChargePrimary { get; set; }


        public int NodeInChargeSecondary { get; set; }

        public List<string> RelayConnected { get; set; }

        public Dictionary<string, string> RelayIdToUnitPortId { get; set; }

        public List<string> SensorsConnected { get; set; }


        public void TurnOn(string RelayId, string PortId)
        {
            throw new NotImplementedException();
        }
    }
}
