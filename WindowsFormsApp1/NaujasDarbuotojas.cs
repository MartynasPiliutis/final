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

            object[] theList = Program.gateRepository.GetAllGateNameAndCodeArray();
            add_gates_dropbox.Items.AddRange(theList);

            int generateId = Program.employeeRepository.NewEmployeeIdGenerator();
            add_textbox_autoId.Text = Convert.ToString(generateId);
        }

        private void add_textbox_autoId_TextChanged(object sender, EventArgs e)
        {

        }

        private void add_gates_dropbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        /*private void add_gate_add_Click(object sender, EventArgs e)
        {
            int teisesId = add_gates_dropbox.Items.;
            if (balas < 1 || balas > 10)
            {
                MessageBox.Show("Neteisingai ivestas pazymys...");
                return;
            }

            add_listbox_selectGate.Items.Add($"{}");
        }*/
    }
}
