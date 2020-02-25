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
    public partial class AtaskaitaDarbuotojuValandos : Form
    {
        public AtaskaitaDarbuotojuValandos()
        {
            InitializeComponent();
            object[] theList = Program.employeeRepository.GetAllEmployeeId();
            dfind_dropbox_idList.Items.AddRange(theList);
            dfind_dropbox_idList.Items.Add("Visi");
        }

        private void dfind_button_find_Click(object sender, EventArgs e)
        {
            DateTime startDate = data_pradzia.Value;
            DateTime endDate = data_pabaiga.Value;
            if (startDate > endDate)
            {
                MessageBox.Show("Klaida!\n" + "Neteisingai pasirinkta data:\n" + "Pradžios data yra vėlesnė, nei pabaigos data.");
                return;
            }
            employee_button_find.Enabled = true;
        }

        private void dfind_dropbox_idList_SelectedIndexChanged(object sender, EventArgs e)
        {
            dfind_button_find.Enabled = true;
            Ataskaita_dataGridView.Rows.Clear();
        }

        private void employee_button_find_Click(object sender, EventArgs e)
        {
            FiltrasAll.Enabled = true;
        }

        private void FiltrasAll_Enter(object sender, EventArgs e)
        {
            button_filtruoti.Enabled = true;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            Ataskaita_dataGridView.Rows.Clear();
            dfind_dropbox_idList.Items.Clear();
            object[] theList = Program.employeeRepository.GetAllEmployeeId();
            dfind_dropbox_idList.Items.AddRange(theList);
            check_filter_All.Checked = false;
            check_filter_true.Checked = false;
            check_filter_false.Checked = false;
            FiltrasAll.Enabled = false;
            button_filtruoti.Enabled = false;
            employee_button_find.Enabled = false;
        }


        private void button_back_Click(object sender, EventArgs e)
        {
            Ataskaitos ataskaitos = new Ataskaitos();
            this.Hide();
            ataskaitos.ShowDialog();
            this.Close();
        }

        private void button_filtruoti_Click(object sender, EventArgs e)
        {
            Ataskaita_dataGridView.Rows.Clear();
            Employee darbuotojas = Program.employeeRepository.GetEmployeeById(Convert.ToInt32(dfind_dropbox_idList.SelectedItem));
            int searchId = darbuotojas.EmployeeId;
            List<Event> listToReportAllEvents = Program.eventRepository.GetAllEventList();
            DateTime startDate = data_pradzia.Value;
            DateTime endDate = data_pabaiga.Value;
            List <Event> listOfEvents = Program.eventRepository.GetAllEventList();
            List<ReportPeriod> listToReportEventsByTime = Program.reportGenerator.GenarateReportOfPeriod(startDate, endDate, listOfEvents);
            int eilNr = 1;
            int rowNr = 0;
            if (check_filter_All.Checked == true)
            {
                foreach (var item in listToReportEventsByTime)
                {
                        UzpildytiAtaskaita(ref eilNr, ref rowNr, item);
                }
            }
            else if (check_filter_true.Checked == true)
            {
                foreach (var item in listToReportEventsByTime)
                {
                    if (item.Pass == true)
                    {
                        UzpildytiAtaskaita(ref eilNr, ref rowNr, item);
                    }
                }
            }
            else if (check_filter_false.Checked == true)
            {
                foreach (var item in listToReportEventsByTime)
                {
                    if (item.Pass == false)
                    {
                        UzpildytiAtaskaita(ref eilNr, ref rowNr, item);
                    }
                }
            }

        }

        private void UzpildytiAtaskaita(ref int eilNr, ref int rowNr, ReportPeriod item)
        {
            string name = Program.employeeRepository.GetEmployeeById(item.EmployeeId).NameSurname;
            string gate = Program.gateRepository.GetGateCodeByID(item.GateId);
            DateTime data = item.PassTime;
            bool raktas = item.Pass;
            Ataskaita_dataGridView.Rows.Add();
            Ataskaita_dataGridView.Rows[rowNr].Cells[0].Value = eilNr;
            Ataskaita_dataGridView.Rows[rowNr].Cells[1].Value = item.EmployeeId;
            Ataskaita_dataGridView.Rows[rowNr].Cells[2].Value = name;
            Ataskaita_dataGridView.Rows[rowNr].Cells[3].Value = item.GateId;
            Ataskaita_dataGridView.Rows[rowNr].Cells[4].Value = gate;
            Ataskaita_dataGridView.Rows[rowNr].Cells[5].Value = data;
            Ataskaita_dataGridView.Rows[rowNr].Cells[6].Value = raktas;
            rowNr++;
            eilNr++;
        }

    }
}
