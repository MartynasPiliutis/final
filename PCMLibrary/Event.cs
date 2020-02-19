using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCMLibrary
{
    public class Event
    {
        public long EventId { get; private set; }
        public int EmployeeId { get; private set; }
        public int GateId { get; private set; }
        public DateTime PassTime { get; private set; }
        public bool Pass { get; private set; }

        public Event(long eventId, int employeeId, int gateId, DateTime passtime, bool pass)
        {
            EventId = eventId;
            EmployeeId = employeeId;
            GateId = gateId;
            PassTime = passtime;
            Pass = pass;
        }
    }
}
