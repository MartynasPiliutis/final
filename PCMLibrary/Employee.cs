using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCMLibrary
{
    public class Employee
    {
        public int EmployeeId { get; private set; }
        public string NameSurname { get; private set; }
        private Right EmployeeRight;
public Employee(int employeeId, string nameSurname, Right employeeRight)
        {
            EmployeeId = employeeId;
            NameSurname = nameSurname;
            EmployeeRight = employeeRight;
        }
    }
}
