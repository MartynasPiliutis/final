using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PCMLibrary;

namespace PCMSystem
{
    public partial class Ataskaita_Visi : Form
    {
        public Ataskaita_Visi()
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
                long id = item.EventId;
                int employeeId = item.EmployeeId;
                string name = Program.employeeRepository.GetEmployeeById(item.EmployeeId).NameSurname;
                string gate = Program.gateRepository.GetGateCodeByID(item.GateId);
                string data = Convert.ToString($"{item.PassTime.Year}-{item.PassTime.Month.ToString("D2")}-{item.PassTime.Day.ToString("D2")}");
                string time = Convert.ToString($"{item.PassTime.Hour.ToString("D2")}:{item.PassTime.Minute.ToString("D2")}:{item.PassTime.Second.ToString("D2")}");
                bool raktas = item.Pass;

                Ataskaita_dataGridView.Rows.Add();
                Ataskaita_dataGridView.Rows[rowNr].Cells[0].Value = id;
                Ataskaita_dataGridView.Rows[rowNr].Cells[1].Value = eilNr;
                Ataskaita_dataGridView.Rows[rowNr].Cells[2].Value = employeeId;
                Ataskaita_dataGridView.Rows[rowNr].Cells[3].Value = name;
                Ataskaita_dataGridView.Rows[rowNr].Cells[4].Value = gate;
                Ataskaita_dataGridView.Rows[rowNr].Cells[5].Value = data;
                Ataskaita_dataGridView.Rows[rowNr].Cells[6].Value = time;
                Ataskaita_dataGridView.Rows[rowNr].Cells[7].Value = raktas;
                rowNr++;
                eilNr++;
            }
        }

        private void report_button_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
