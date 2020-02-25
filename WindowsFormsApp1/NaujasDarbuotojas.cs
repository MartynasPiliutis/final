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
    public partial class NaujasDarbuotojas : Form
    {
        public NaujasDarbuotojas()
        {
            InitializeComponent();
            checkedListBox_gates.Enabled = false;
            object[] theList = Program.gateRepository.GetAllGateNameAndCodeArrayV2();
            checkedListBox_gates.Items.AddRange(theList);

            int generateId = Program.employeeRepository.NewEmployeeIdGenerator();
            add_textbox_autoId.Text = Convert.ToString(generateId);
        }

        private void add_button_clear_Click(object sender, EventArgs e)
        {
            add_texboxt_input_name.Clear();
            add_button_add.Enabled = false;
        }

        private void add_button_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Darbuotojai darbuotojai = new Darbuotojai();
            darbuotojai.ShowDialog();
            this.Close();
        }

        private void checkedListBox_gates_SelectedIndexChanged(object sender, EventArgs e)
        {
            add_button_add.Enabled = true;
        }

        private void add_texboxt_input_name_TextChanged(object sender, EventArgs e)
        {
            checkedListBox_gates.Enabled = true;
            if (add_texboxt_input_name.TextLength == 0 )
            {
                checkedListBox_gates.Enabled = false;
                checkedListBox_gates.Items.Clear();
                object[] theList = Program.gateRepository.GetAllGateNameAndCodeArrayV2();
                checkedListBox_gates.Items.AddRange(theList);
            }
        }

        private void add_button_add_Click(object sender, EventArgs e)
        {
            List<int> gateList = new List<int>();
            foreach (var item in checkedListBox_gates.CheckedItems)
            {
                int gateId = Convert.ToInt32(item);
                gateList.Add(gateId);
            }
            int newEmployeeId = Convert.ToInt32(add_textbox_autoId.Text);
            string newEmployeeName = add_texboxt_input_name.Text;
            Program.employeeRepository.AddNewEmployee(newEmployeeId, newEmployeeName, gateList);
            MessageBox.Show("Naujas darbuotojas pridėtas!\n" + $"ID: {newEmployeeId}, Vardas: {newEmployeeName}");
            checkedListBox_gates.Items.Clear();
            object[] theList = Program.gateRepository.GetAllGateNameAndCodeArrayV2();
            checkedListBox_gates.Items.AddRange(theList);
            checkedListBox_gates.Enabled = false;
            add_button_add.Enabled = false;
            checkedListBox_gates.Enabled = false;
            add_texboxt_input_name.ResetText();
            add_textbox_autoId.ResetText();
            int generateId = Program.employeeRepository.NewEmployeeIdGenerator();
            add_textbox_autoId.Text = Convert.ToString(generateId);
        }
    }
    
}
