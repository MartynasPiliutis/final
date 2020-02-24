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
    public partial class TrintiPraejima : Form
    {
        public TrintiPraejima()
        {
            InitializeComponent();
            gdelete_button_find.Enabled = false;
            object[] theList = Program.gateRepository.GetAllGateNameAndCodeArrayV2();
            gdelete_dropbox_idList.Items.AddRange(theList);
        }

        private void gdelete_dropbox_idList_SelectedIndexChanged(object sender, EventArgs e)
        {
            gdelete_button_find.Enabled = true;
        }

        private void gdelete_button_find_Click(object sender, EventArgs e)
        {
            gdelete_textbox_output.Items.Clear();

            string vartai = Program.gateRepository.GetGateCodeByID(Convert.ToInt32(gdelete_dropbox_idList.SelectedItem));
            gdelete_textbox_output.Items.Add($"Vartų ID: {Convert.ToInt32(gdelete_dropbox_idList.SelectedItem)}");
            gdelete_textbox_output.Items.Add($"Vartų vardas: {vartai}");

            gdelete_button_delete.Enabled = true;
        }

        private void gdelete_button_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Vartai vartai = new Vartai();
            vartai.ShowDialog();
            this.Close();
        }

        private void gdelete_button_delete_Click(object sender, EventArgs e)
        {
            string vartai = Program.gateRepository.GetGateCodeByID(Convert.ToInt32(gdelete_dropbox_idList.SelectedItem));
            var result = MessageBox.Show("Ar tikrai norite trinti šį praėjimą:\n" + $"{Convert.ToInt32(gdelete_dropbox_idList.SelectedItem)} {vartai}", "Trinti Praėjimą?", MessageBoxButtons.OKCancel);
            if (result == DialogResult.Cancel)
            {
                return;
            }
            Program.gateRepository.RemoveGate(Convert.ToInt32(Convert.ToInt32(gdelete_dropbox_idList.SelectedItem)));
            gdelete_button_delete.Enabled = false;
            gdelete_button_find.Enabled = false;
            gdelete_textbox_output.Items.Clear();
            gdelete_dropbox_idList.Items.Clear();
            object[] theList = Program.gateRepository.GetAllGateNameAndCodeArrayV2();
            gdelete_dropbox_idList.Items.AddRange(theList);
            gdelete_dropbox_idList.ResetText();
        }

        private void gdelete_dropbox_idList_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            gdelete_button_find.Enabled = true;
        }
    }
}
