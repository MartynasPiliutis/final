using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCMLibrary
{
    public class Gate
    {
        public int GateId { get; private set; }
        public string GateName { get; private set; }

        public Gate(int gateId, string gateName)
        {
            GateId = gateId;
            GateName = gateName;
        }
    }
}
