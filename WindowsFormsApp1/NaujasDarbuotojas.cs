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

            
            object[] theList = Program.gateRepository.GetAllGateNameAndCodeArrayV2();
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

        private void add_gate_add_Click(object sender, EventArgs e)
        {
            if (add_gates_dropbox.SelectedItem == null)
            {
                MessageBox.Show("Nepazymeta reiksme...");
                return;
            }
            int gateId = Convert.ToInt32(add_gates_dropbox.SelectedItem);
            string gate = Program.gateRepository.GetGateCodeByID(gateId);
            string valueToAdd = Convert.ToString($"{gateId} {gate}");

            if (add_button_add.Enabled == false)
            {
                add_listbox_selectGate.Items.Add($"{gateId} {gate}");
                add_button_add.Enabled = true;
            }
            else
            {
                foreach (var item in add_listbox_selectGate.Items)
                {
                    string value = Convert.ToString(item);
                    if (value == valueToAdd)
                    {
                        MessageBox.Show("Tokia reiksme jau pateikta...");
                        return;
                    }
                    add_listbox_selectGate.Items.Add($"{valueToAdd}");
                    /*else
                    {
                        add_listbox_selectGate.Items.Add($"{valueToAdd}");
                        value = "";
                    }*/
                }
            }
             
        }

        private void add_gate_remove_Click(object sender, EventArgs e)
        {
            if (add_listbox_selectGate.SelectedItem == null)
            {
                MessageBox.Show("Nepazymeta reiksme...");
                return;
            }
            
            add_listbox_selectGate.Items.Remove(add_listbox_selectGate.Items[add_listbox_selectGate.SelectedIndex]);
        }

        private void add_button_clear_Click(object sender, EventArgs e)
        {
            add_texboxt_input_name.Clear();
            add_listbox_selectGate.Items.Clear();
            add_button_add.Enabled = false;
        }
    }
    
}
