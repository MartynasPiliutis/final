using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCMLibrary
{
    public class ReportPeriod
    {
        public int EmployeeId { get; private set; }
        public string Name { get; private set; }
        public int GateId { get; private set; }
        public DateTime PassTime { get; private set; }
        public bool Pass { get; private set; }

        public ReportPeriod(int employeeId, string name, int gateId, DateTime passTime, bool pass)
        {
            EmployeeId = employeeId;
            Name = name;
            GateId = gateId;
            PassTime = passTime;
            Pass = pass;
        }
    }
}
