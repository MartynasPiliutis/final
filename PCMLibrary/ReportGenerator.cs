﻿using System;
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

        List<ReportEvent> reportEvents = new List<ReportEvent>();
        public List<ReportEvent> GanerateAllEventsReport()
        {
            foreach (var oneEvent in EventList)
            {
                string name = employeeRepository.GetEmployeeById(oneEvent.EmployeeId).NameSurname;
                string gateName = gateRepository.GetGateCodeByID(oneEvent.GateId);
                reportEvents.Add(new ReportEvent(name, gateName, oneEvent.PassTime, oneEvent.Pass));
            }
            return reportEvents;
        }

        List<ReportTotalHours> reportTotalHours = new List<ReportTotalHours>();
        public List<ReportTotalHours> GenerateTotalHoursReport()
        {
            for (int id = 2001; id <= 2020; id++)
            {
                List<ReportOnePass> reportOnePass = new List<ReportOnePass>();
                double totalHours = 0;
                foreach (var oneEvent in EventList)
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
                            double timeIn = (passTimeOut - passTimeIn).TotalMinutes;
                            totalHours = totalHours + timeIn;
                        }
                        else
                        {
                            DateTime passTimeIn = reportOnePass[i].OnePass;
                            DateTime passTimeOut = reportOnePass[j].OnePass;
                            double timeIn = (passTimeOut - passTimeIn).TotalMinutes;
                            totalHours = totalHours + timeIn;
                        }
                    }
                } else for (int i = 0; i < reportOnePass.Count - 1; i = i + 2)
                {
                    int j = i + 1;
                    DateTime passTimeIn = reportOnePass[i].OnePass;
                    DateTime passTimeOut = reportOnePass[j].OnePass;
                    double timeIn = (passTimeOut - passTimeIn).TotalMinutes;
                    totalHours = totalHours + timeIn;
                }
                string name = employeeRepository.GetEmployeeById(id).NameSurname;
                reportTotalHours.Add(new ReportTotalHours(name, totalHours));
            }
            return reportTotalHours;
        }
    }
}
