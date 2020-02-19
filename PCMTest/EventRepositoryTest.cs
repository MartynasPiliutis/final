using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using PCMLibrary;

namespace PCMTest
{
    [TestClass]
    public class EventRepositoryTest
    {
        [TestMethod]
        public void PatikrinameArGrazinaVisaSarasa()
        {
            EventRepository eventRepository = new EventRepository();
            int EventListCount = eventRepository.GetAllEventList().Count;
            Assert.AreEqual(EventListCount, 4000);
        }

        [TestMethod]
        public void PatikrinameArGrazinaVisaSarasaPagalId()
        {
            EventRepository eventRepository = new EventRepository();
            int EventListCount = eventRepository.GetAllEventListByEmployeeId(2010).Count;
            Assert.AreEqual(EventListCount, 203);
        }

        [TestMethod]
        public void PatikrinameArGrazinaVisaSarasaPagalIdSuTrueIvykiais()
        {
            EventRepository eventRepository = new EventRepository();
            int EventListCount = eventRepository.GetAllEventListByEmployeeIdThatPassed(2020).Count;
            Assert.AreEqual(EventListCount, 105);
        }

        [TestMethod]
        public void PatikrinameArGrazinaVisaSarasaPagalData()
        {
            EventRepository eventRepository = new EventRepository();
            DateTime startDate = new DateTime(2020, 1, 3,0,0,0);
            DateTime endDate = new DateTime(2020,2,1,23,59,59);
            int EventListCount = eventRepository.GetAllEventListByDate(startDate,endDate).Count;
            Assert.AreEqual(EventListCount, 1995);
        }

        [TestMethod]
        public void PatikrinameArGrazinaVisaSarasaPagalDataSuTrueIvykiais()
        {
            EventRepository eventRepository = new EventRepository();
            DateTime startDate = new DateTime(2020, 1, 3, 0, 0, 0);
            DateTime endDate = new DateTime(2020, 2, 1, 23, 59, 59);
            int EventListCount = eventRepository.GetAllTrueEventListByDate(startDate, endDate).Count;
            Assert.AreEqual(EventListCount, 803);
        }
    }
}
