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
    public partial class AtaskaitaDarbuotojai : Form
    {
        public AtaskaitaDarbuotojai()
        {
            InitializeComponent();
            object[] theList = Program.employeeRepository.GetAllEmployeeId();
            dfind_dropbox_idList.Items.AddRange(theList);
        }

        private void dfind_dropbox_idList_SelectedIndexChanged(object sender, EventArgs e)
        {
            dfind_button_find.Enabled = true;
            Ataskaita_dataGridView.Rows.Clear();
        }

        private void dfind_button_find_Click(object sender, EventArgs e)
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
            dfind_dropbox_idList.Items.Clear();
            object[] theList = Program.employeeRepository.GetAllEmployeeId();
            dfind_dropbox_idList.Items.AddRange(theList);
            Ataskaita_dataGridView.Rows.Clear();
            dfind_button_find.Enabled = false;
            check_filter_All.Checked = false;
            check_filter_true.Checked = false;
            check_filter_false.Checked = false;
            FiltrasAll.Enabled = false;
            button_filtruoti.Enabled = false;
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
            List<Event> listToReport = Program.eventRepository.GetAllEventList();
            int eilNr = 1;
            int rowNr = 0;
            if (check_filter_All.Checked == true)
            {
                foreach (var item in listToReport)
                {
                    if (item.EmployeeId == searchId)
                    {
                        UzpildytiAtaskaita(ref eilNr, ref rowNr, item);
                    }
                }
            }
            else if (check_filter_true.Checked == true)
            {
                foreach (var item in listToReport)
                {
                    if (item.EmployeeId == searchId && item.Pass == true)
                    {
                        UzpildytiAtaskaita(ref eilNr, ref rowNr, item);
                    }
                }
            }
            else if (check_filter_false.Checked == true)
            {
                foreach (var item in listToReport)
                {
                    if (item.EmployeeId == searchId && item.Pass == false)
                    {
                        UzpildytiAtaskaita(ref eilNr, ref rowNr, item);
                    }
                }
            }

        }

        private void UzpildytiAtaskaita(ref int eilNr, ref int rowNr, Event item)
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
}
