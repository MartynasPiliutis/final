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
    public partial class TrintiDarbuotoja : Form
    {
        public TrintiDarbuotoja()
        {
            InitializeComponent();
            object[] theList = Program.employeeRepository.GetAllEmployeeId();
            delete_dropbox_idList.Items.AddRange(theList);
        }

        private void delete_dropbox_idList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void delete_button_find_Click(object sender, EventArgs e)
        {
            delete_textbox_output.Items.Clear();

            Employee darbuotojas = Program.employeeRepository.GetEmployeeById(Convert.ToInt32(delete_dropbox_idList.SelectedItem));
            delete_textbox_output.Items.Add($"Darbuotojo ID: {darbuotojas.EmployeeId}");
            delete_textbox_output.Items.Add($"Darbuotojo vardas: {darbuotojas.NameSurname}");
            delete_textbox_output.Items.Add($"Darbuotojo teises:");
            foreach (var item in Program.gateRepository.GetGateList())
            {
                string gate = item.GateName;
                int gateId = item.GateId;
                string leidimas;
                bool pass = darbuotojas.CheckEmployeeHasRight(gateId);
                if (pass == true) { leidimas = "Galima"; } else { leidimas = "Negalima"; }
                delete_textbox_output.Items.Add($"{gate} (ID: {gateId}): {leidimas}");
            }
            delete_button_delete.Enabled = true;
        }

        private void delete_button_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Darbuotojai darbuotojai = new Darbuotojai();
            darbuotojai.ShowDialog();
            this.Close();
        }

        private void delete_button_delete_Click(object sender, EventArgs e)
        {
            Program.employeeRepository.RemoveEmployee(Convert.ToInt32(delete_dropbox_idList.SelectedItem));
            delete_button_delete.Enabled = false;
            delete_textbox_output.Items.Clear();
            delete_dropbox_idList.Items.Clear();
            object[] theList = Program.employeeRepository.GetAllEmployeeId();
            delete_dropbox_idList.Items.AddRange(theList);
            delete_dropbox_idList.ResetText();
        }
    }
}
