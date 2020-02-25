using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCMSystem
{
    public partial class NaujiVartai : Form
    {
        public NaujiVartai()
        {
            InitializeComponent();
            addgate_button_add.Enabled = false;
            int generateId = Program.gateRepository.NewGateIdGenerator();
            addgate_textbox_autoId.Text = Convert.ToString(generateId);
        }

        private void addgate_button_clear_Click(object sender, EventArgs e)
        {
            addgate_texboxt_input_name.Clear();
        }

        private void addgate_button_back_Click(object sender, EventArgs e)
        {
            Vartai vartai = new Vartai();
            this.Hide();
            vartai.ShowDialog();
            this.Close();
        }

        private void addgate_button_add_Click(object sender, EventArgs e)
        {
            int newId = Convert.ToInt32(addgate_textbox_autoId.Text);
            string newGateName = addgate_texboxt_input_name.Text;
            Program.gateRepository.AddNewGate(newId, newGateName);
            addgate_texboxt_input_name.Clear();
            addgate_textbox_autoId.ResetText();
            int generateId = Program.gateRepository.NewGateIdGenerator();
            addgate_textbox_autoId.Text = Convert.ToString(generateId);
            addgate_button_add.Enabled = false;
            MessageBox.Show("Pridėtas naujas praėjimas:\n" + $"ID: {newId}, Pavadinimas: {newGateName}");
        }

        private void addgate_texboxt_input_name_TextChanged(object sender, EventArgs e)
        {
            addgate_button_add.Enabled = true;
        }
    }
}
