using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using PCMLibrary;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCMTest
{
    [TestClass]
    public class ReportGeneratorTest
    {
        [TestMethod]
        public void TikrinameArGrazinaVisaEventListSarasa()
        {
            EmployeeRepository employeeRepository = new EmployeeRepository();
            EventRepository eventRepository = new EventRepository();
            GateRepository gateRepository = new GateRepository();
            List<Event> EventList = new List<Event>();
            ReportGenerator reportGenerator = new ReportGenerator(employeeRepository, gateRepository, EventList);
            List <Event> ListToReport = eventRepository.GetAllEventList();
            int AllEventsCount = reportGenerator.GanerateAllEventsReport(ListToReport).Count;
            Assert.AreEqual(AllEventsCount, 4000);
        }
        [TestMethod]
        public void TikrinameArGenerateTotalHoursReportGrazinaTeisingaKiekiIrasu()
        {
            EmployeeRepository employeeRepository = new EmployeeRepository();
            EventRepository eventRepository = new EventRepository();
            GateRepository gateRepository = new GateRepository();
            List<Event> EventList = new List<Event>();
            ReportGenerator reportGenerator = new ReportGenerator(employeeRepository, gateRepository, EventList);
            List<Event> OneDayEvents = eventRepository.GetAllOneDayEvents(new DateTime(2020, 1, 20));
            int TotalHoursCount = reportGenerator.GenerateTotalHoursReport(OneDayEvents).Count;
            Assert.AreEqual(TotalHoursCount, 14);

        }
        [TestMethod]
        public void TikrinameArGrazinaVisaEventListSarasaPagalData()
        {
            EmployeeRepository employeeRepository = new EmployeeRepository();
            EventRepository eventRepository = new EventRepository();
            GateRepository gateRepository = new GateRepository();
            List<Event> EventList = new List<Event>();
            ReportGenerator reportGenerator = new ReportGenerator(employeeRepository, gateRepository, EventList);
            List<Event> ListToReport = eventRepository.GetAllEventList();
            int PeriodEventsCount = reportGenerator.GenarateReportOfPeriod(new DateTime(2020,1,10), new DateTime(2020,2,9), ListToReport).Count;
            Assert.AreEqual(PeriodEventsCount, 2080);
        }
    }
}
