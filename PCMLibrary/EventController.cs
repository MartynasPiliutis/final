using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCMLibrary
{
    public class EventController
    {
        //DEPENDENCY INJECTION START
        private EmployeeRepository employeeRepository;
        public EventController(EmployeeRepository emploRepo)
        {
            this.employeeRepository = emploRepo;
        }
        //DEPENDENCY INJECTION START

        List<Event> EventList = new List<Event>();
        public bool TryPass(int employeeId, int gateIdPass)
        {
            Employee employee = employeeRepository.GetEmployeeById(employeeId);
            bool employeePass;
            int employeeIdFind = employee.EmployeeId;
            employeePass = employee.CheckEmployeeHasRight(gateIdPass);
            EventList.Add(new Event(GetNewEventId(), employeeId, gateIdPass, GetNewEventPassTime(), employeePass));
            return employeePass;
        }

        public List<Event> SaveTryPass(int employeeId, int gateIdPass)
        {
            Employee employee = employeeRepository.GetEmployeeById(employeeId);
            bool employeePass;
            int employeeIdFind = employee.EmployeeId;
            employeePass = employee.CheckEmployeeHasRight(gateIdPass);
            Event actionSave = new Event(GetNewEventId(), employeeId, gateIdPass, GetNewEventPassTime(), employeePass);
            EventList.Add(actionSave);
            return EventList;
        }

        public long GetNewEventId()
        {
            string smon = DateTime.Now.Month.ToString("D2");
            string sday = DateTime.Now.Day.ToString("D2");
            string sh = DateTime.Now.Hour.ToString("D2");
            string smin = DateTime.Now.Minute.ToString("D2");
            string ssec = DateTime.Now.Second.ToString("D2");
            string smsec = DateTime.Now.Millisecond.ToString("D2");
            return Convert.ToInt64($"{DateTime.Now.Year}{smon}{sday}{sh}{smin}{ssec}{smsec}");
        }

        public DateTime GetNewEventPassTime()
        {
            return DateTime.Now;
        }
    }
}
