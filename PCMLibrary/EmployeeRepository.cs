﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCMLibrary
{
    public class EmployeeRepository
    {
        private List<Employee> EmployeeList;
        public EmployeeRepository()
        {
            EmployeeList = new List<Employee>();
            EmployeeList.Add(new Employee(2001, "Jonas Jonaitis", new List<int> { 31, 32 }));
            EmployeeList.Add(new Employee(2002, "Petras Petraitis", new List<int> { 32, 34 }));
            EmployeeList.Add(new Employee(2003, "Tomas Pakalnis", new List<int> { 31, 32, 33, 34 }));
            EmployeeList.Add(new Employee(2004, "Aleksas Norkus", new List<int> { 33 }));
            EmployeeList.Add(new Employee(2005, "Rimas Kaukas", new List<int> { 31 }));
            EmployeeList.Add(new Employee(2006, "Linas Bruzas", new List<int> { 34 }));
            EmployeeList.Add(new Employee(2007, "Janina Petrauskiene", new List<int> { 33, 34 }));
            EmployeeList.Add(new Employee(2008, "Kazys Ozelis", new List<int> { 31, 34 }));
            EmployeeList.Add(new Employee(2009, "Simona Druskyte", new List<int> { 33, 34 }));
            EmployeeList.Add(new Employee(2010, "Ruta Siaule", new List<int> { 32, 33 }));
            EmployeeList.Add(new Employee(2011, "Kestas Bauza", new List<int> { 31, 32, 33 }));
            EmployeeList.Add(new Employee(2012, "Jonas Vidauskas", new List<int> { 32, 34 }));
            EmployeeList.Add(new Employee(2013, "Tom Jersey", new List<int> { 34 }));
            EmployeeList.Add(new Employee(2014, "Nijole Lukauskiene", new List<int> { 32 }));
            EmployeeList.Add(new Employee(2015, "George Smith", new List<int> { 33 }));
            EmployeeList.Add(new Employee(2016, "Nojus Cicenas", new List<int> { 31 }));
            EmployeeList.Add(new Employee(2017, "Haroldas Eitutis", new List<int> { 32 }));
            EmployeeList.Add(new Employee(2018, "Bronius Nauseda", new List<int> { 31 }));
            EmployeeList.Add(new Employee(2019, "John Doe", new List<int> { 33 }));
            EmployeeList.Add(new Employee(2020, "Deimante Klimiene", new List<int> { 33, 34 }));
        }

        public List<Employee> GetEmployeeList()
        {
            return EmployeeList;
        }

        public void AddNewEmployee(int newEmployeeId, string newEmployeeName, List<int> gateList)
        {
            if (GetEmployeeById(newEmployeeId) == null)
            {
                EmployeeList.Add(new Employee(newEmployeeId, newEmployeeName, gateList));
            }
        }

        public int NewEmployeeIdGenerator()
        {
            List<Employee> currentList = GetEmployeeList();
            int idMax = currentList.Max(lastId => lastId.EmployeeId);
            int idNew = idMax + 1;
            return idNew;
        }


        public void RemoveEmployee(int removeEmloyeeId)
        {
            if (GetEmployeeById(removeEmloyeeId) != null)
            {
                for (int i = 0; i < EmployeeList.Count; i++)
                {
                    if (removeEmloyeeId == EmployeeList[i].EmployeeId)
                    {
                        EmployeeList.RemoveAt(i);
                        return;
                    }
                }
            }
        }

        public Employee GetEmployeeById(int findEmployeeId)
        {
            foreach (var employee in EmployeeList)
            {
                if (findEmployeeId == employee.EmployeeId)
                {
                    return employee;
                }
            }
            return null;
        }
        public object[] GetAllEmployeeId()
        {
            int arrayLenght = EmployeeList.Count;
            object[] employeeIdList = new object[arrayLenght];
            for (int i = 0; i < arrayLenght; i++)
            {
                employeeIdList[i] = EmployeeList[i].EmployeeId;
            }

            return employeeIdList;
        }
    }
}
