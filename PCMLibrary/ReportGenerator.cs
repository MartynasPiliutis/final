using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCMLibrary
{
    public class ReportGenerator
    {
        private EmployeeRepository employeeRepository;
        private GateRepository gateRepository;
        public List<Event> EventList;

        public ReportGenerator(EmployeeRepository employeeRepository, GateRepository gateRepository, List<Event> eventList)
        {
            this.employeeRepository = employeeRepository;
            this.gateRepository = gateRepository;
            EventList = eventList;
        }

        public List<ReportEvent> GanerateAllEventsReport(List<Event> listOfEvent)
        {
            List<ReportEvent> reportEvents = new List<ReportEvent>();
            foreach (var oneEvent in listOfEvent)
            {
                string name = employeeRepository.GetEmployeeById(oneEvent.EmployeeId).NameSurname;
                string gateName = gateRepository.GetGateCodeByID(oneEvent.GateId);
                reportEvents.Add(new ReportEvent(name, gateName, oneEvent.PassTime, oneEvent.Pass));
            }
            return reportEvents;
        }

        public List<ReportTotalHours> GenerateTotalHoursReport(List<Event> listOfEvents)
        {
            List<ReportTotalHours> reportTotalHours = new List<ReportTotalHours>();
            int min = listOfEvents.Min(passEvent => passEvent.EmployeeId);
            int max = listOfEvents.Max(passEvent => passEvent.EmployeeId);
            for (int id = min; id <= max; id++)
            {
                List<ReportOnePass> reportOnePass = new List<ReportOnePass>();
                List<Event> ListOfEvents = listOfEvents;
                double totalHours = 0.00d;
                double timeIn = 0.00d;
                foreach (var oneEvent in ListOfEvents)
                {
                    int employeeId = oneEvent.EmployeeId;
                    if (oneEvent.Pass == true && employeeId == id)
                    {
                        ReportOnePass onePass = new ReportOnePass(oneEvent.PassTime);
                        reportOnePass.Add(onePass);
                    }
                }

                if (reportOnePass.Count % 2 != 0)
                {
                    for (int i = 0; i < reportOnePass.Count; i = i + 2)
                    {
                        int j = i + 1;
                        if (j == reportOnePass.Count)
                        {
                            DateTime passTimeIn = reportOnePass[i].OnePass;
                            DateTime passTimeOut = new DateTime(reportOnePass[i].OnePass.Year, reportOnePass[i].OnePass.Month, reportOnePass[i].OnePass.Day, 17, 0, 0, 0);
                            timeIn = (passTimeOut - passTimeIn).TotalMinutes;
                            totalHours = totalHours + timeIn;
                        }
                        else
                        {
                            DateTime passTimeIn = reportOnePass[i].OnePass;
                            DateTime passTimeOut = reportOnePass[j].OnePass;
                            timeIn = (passTimeOut - passTimeIn).TotalMinutes;
                            totalHours = totalHours + timeIn;
                        }
                    }
                }
                else for (int i = 0; i < reportOnePass.Count - 1; i = i + 2)
                {
                    int j = i + 1;
                    DateTime passTimeIn = reportOnePass[i].OnePass;
                    DateTime passTimeOut = reportOnePass[j].OnePass;
                    timeIn = (passTimeOut - passTimeIn).TotalMinutes;
                    totalHours = totalHours + timeIn;
                }
                if (totalHours != 0)
                {
                    string name = employeeRepository.GetEmployeeById(id).NameSurname;
                    reportTotalHours.Add(new ReportTotalHours(name, totalHours));
                }
                
            }
            return reportTotalHours;
        }

        public List<ReportPeriod> GenarateReportOfPeriod(DateTime startDate, DateTime endDate, List<Event> listOfEvent)
        {
            List<ReportPeriod> reportPeriod = new List<ReportPeriod>();
            DateTime start = new DateTime(startDate.Year, startDate.Month, startDate.Day, 0, 0 ,0);
            DateTime end = new DateTime(endDate.Year, endDate.Month, endDate.Day, 23, 59, 59);
            foreach (var item in listOfEvent)
            {
                if (item.PassTime >= start && item.PassTime <= end)
                {
                    reportPeriod.Add(new ReportPeriod(item.EmployeeId, employeeRepository.GetEmployeeById(item.EmployeeId).NameSurname, item.PassTime, item.Pass));
                }
            }
            return reportPeriod;
        }
    }
}
