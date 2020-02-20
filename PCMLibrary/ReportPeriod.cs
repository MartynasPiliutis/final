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
        public DateTime PassTime { get; private set; }
        public bool Pass { get; private set; }

        public ReportPeriod(int employeeId, string name, DateTime passTime, bool pass)
        {
            EmployeeId = employeeId;
            Name = name;
            PassTime = passTime;
            Pass = pass;
        }
    }
}
