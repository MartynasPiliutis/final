﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PCMLibrary;
using System.IO;

namespace PCMSystem
{
    public partial class Ataskaita_False : Form
    {
        public Ataskaita_False()
        {
            InitializeComponent();

        }

        private void Ataskaita_Load(object sender, EventArgs e)
        {
            List<Event> listToReport = Program.eventRepository.GetAllEventList();
            int eilNr = 1;
            int rowNr = 0;
            foreach (var item in listToReport)
            {
                if (item.Pass == false)
                {
                    int employeeId = item.EmployeeId;
                    string name = Program.employeeRepository.GetEmployeeById(item.EmployeeId).NameSurname;
                    string gate = Program.gateRepository.GetGateCodeByID(item.GateId);
                    string data = Convert.ToString($"{item.PassTime.Year}-{item.PassTime.Month.ToString("D2")}-{item.PassTime.Day.ToString("D2")}");
                    string time = Convert.ToString($"{item.PassTime.Hour.ToString("D2")}:{item.PassTime.Minute.ToString("D2")}:{item.PassTime.Second.ToString("D2")}");
                    bool raktas = item.Pass;
                    Ataskaita_dataGridView.Rows.Add();
                    Ataskaita_dataGridView.Rows[rowNr].Cells[0].Value = eilNr;
                    Ataskaita_dataGridView.Rows[rowNr].Cells[1].Value = employeeId;
                    Ataskaita_dataGridView.Rows[rowNr].Cells[2].Value = name;
                    Ataskaita_dataGridView.Rows[rowNr].Cells[3].Value = gate;
                    Ataskaita_dataGridView.Rows[rowNr].Cells[4].Value = data;
                    Ataskaita_dataGridView.Rows[rowNr].Cells[5].Value = time;
                    Ataskaita_dataGridView.Rows[rowNr].Cells[6].Value = raktas;
                    rowNr++;
                    eilNr++;
                }
            }
            using (TextWriter tw = new StreamWriter("C:\\Users\\kooky\\Documents\\DOTNET\\reports\\ataskaitaFalse.txt"))
            {
                for (int i = 0; i < Ataskaita_dataGridView.Rows.Count; i++)
                {
                    for (int j = 0; j < Ataskaita_dataGridView.Columns.Count; j++)
                    {
                        tw.Write($"{Ataskaita_dataGridView.Rows[i].Cells[j].Value.ToString()},");
                    }
                    tw.WriteLine();
                }
            }
        }

        private void report_button_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
