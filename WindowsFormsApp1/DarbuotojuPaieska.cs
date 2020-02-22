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
    public partial class DarbuotojuPaieska : Form
    {
        public DarbuotojuPaieska()
        {
            InitializeComponent();
            object[] theList = Program.employeeRepository.GetAllEmployeeId();
            dfind_dropbox_idList.Items.AddRange(theList);
        }

        private void dfind_dropbox_idList_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void dfind_button_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Darbuotojai darbuotojai = new Darbuotojai();
            darbuotojai.ShowDialog();
            this.Close();
        }

        private void DarbuotojuPaieska_Load(object sender, EventArgs e)
        {

        }

        private void dfind_button_find_Click(object sender, EventArgs e)
        {
            dfind_textbox_output.Items.Clear();
            
            Employee darbuotojas = Program.employeeRepository.GetEmployeeById(Convert.ToInt32(dfind_dropbox_idList.SelectedItem));
            dfind_textbox_output.Items.Add($"Darbuotojo ID: {darbuotojas.EmployeeId}");
            dfind_textbox_output.Items.Add($"Darbuotojo vardas: {darbuotojas.NameSurname}");
            dfind_textbox_output.Items.Add($"Darbuotojo teises:");
            foreach (var item in Program.gateRepository.GetGateList())
            {
                string gate = item.GateName;
                int gateId = item.GateId;
                string leidimas;
                bool pass = darbuotojas.CheckEmployeeHasRight(gateId);
                if (pass == true) { leidimas = "Galima"; } else { leidimas = "Negalima"; }
                dfind_textbox_output.Items.Add($"{gate} (ID: {gateId}): {leidimas}");
            }
        }

        private void dfind_textbox_output_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
