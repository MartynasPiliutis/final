using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PCMLibrary;
using System.Collections.Generic;

namespace PCMTest
{
    [TestClass]
    public class EmployeeRepositoryTest
    {
        [TestMethod]
        public void TikrinameArGaunameVisaEmployeeRepositorySarasa()
        {
            EmployeeRepository employeeRepository = new EmployeeRepository();
            int employeeListCount = employeeRepository.GetEmployeeList().Count;
            Assert.AreEqual(employeeListCount, 20);
        }

        [TestMethod]
        public void TikrinameArSurandaDarbuotojaPagalEmployeeId()
        {
            //Assign
            EmployeeRepository employeeRepository = new EmployeeRepository();
            //Act
            int findEmployeeId = employeeRepository.GetEmployeeById(2011).EmployeeId;
            //Assert
            Assert.AreEqual(findEmployeeId, 2011);
        }

        [TestMethod]
        public void TikrinameArSukuriaNaujaDarbuotoja()
        {
            //Assign
            EmployeeRepository employeeRepository = new EmployeeRepository();
            //Act

            employeeRepository.AddNewEmployee(2021, "Vardenis Pavardenis", new List<int> { 31, 32});
            //Assert
            int employeeListCount = employeeRepository.GetEmployeeList().Count;

            Assert.AreEqual(employeeListCount, 21);
        }

        [TestMethod]
        public void TikrinameArPasalinaDarbuotoja()
        {
            //Assign
            EmployeeRepository employeeRepository = new EmployeeRepository();
            //Act

            employeeRepository.RemoveEmployee(2020);
            //Assert
            int employeeListCount = employeeRepository.GetEmployeeList().Count;

            Assert.AreEqual(employeeListCount, 19);
        }

        [TestMethod]
        public void TikrinameArGrazinaVisaDarbuotojuIdSarasa()
        {
            EmployeeRepository employeeRepository = new EmployeeRepository();
            int employeeIdListCount = employeeRepository.GetAllEmployeeId().Length;
            Assert.AreEqual(employeeIdListCount, 20);
        }

        [TestMethod]
        public void TikrinameArSukuriaNaujaDidziausiaId()
        {
            EmployeeRepository employeeRepository = new EmployeeRepository();
            List<Employee> EmployeeList = new List<Employee>();
            int newId = employeeRepository.NewEmployeeIdGenerator();
            Assert.AreEqual(newId, 2021);
        }
    }
}
