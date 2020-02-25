using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCMLibrary
{
    public class ReportTotalHours
    {
        public int EmployeeId { get; private set; }
        public string NameSurname { get; private set; }
        public string TotalHours { get; private set; }

        public ReportTotalHours(int employeeId, string nameSurname, double totalHours)
        {
            EmployeeId = employeeId;
            NameSurname = nameSurname;
            TotalHours = Convert.ToString(totalHours);
        }
    }
}
