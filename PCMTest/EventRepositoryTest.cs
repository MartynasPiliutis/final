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
    }
}
