using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using PCMLibrary;

namespace PCMTest
{
    [TestClass]
    public class GateRepositoryTest
    {
        [TestMethod]
        public void PatikrinameArGrazinaVisaPraejimuSarasa()
        {
            //Assign
            GateRepository gateRepository = new GateRepository();
            //Act
            int gateRepositoryList = gateRepository.GetGateList().Count;
            //Assert
            Assert.AreEqual(gateRepositoryList, 4);
        }
        [TestMethod]
        public void PatikrinameArSurandaPraejimaPagalId()
        {
            //Assign
            GateRepository gateRepository = new GateRepository();
            //Act
            string gateRepositoryName = gateRepository.GetGateCodeByID(31);
            //Assert
            Assert.AreEqual(gateRepositoryName, "North Pass");
        }
        [TestMethod]
        public void PatikrinameArPridedaNaujaPraejimaISarasa()
        {
            //Assign
            GateRepository gateRepository = new GateRepository();
            //Act
            gateRepository.AddNewGate(35, "Test Pass");
            //Assert
            int gateRepositoryList = gateRepository.GetGateList().Count;
            Assert.AreEqual(gateRepositoryList, 5);
        }
        [TestMethod]
        public void PatikrinameArPasalinaEsamaPraejima()
        {
            //Assign
            GateRepository gateRepository = new GateRepository();
            //Act
            gateRepository.RemoveGate(34);
            //Assert
            int gateRepositoryList = gateRepository.GetGateList().Count;
            Assert.AreEqual(gateRepositoryList, 3);
        }
    }
}
