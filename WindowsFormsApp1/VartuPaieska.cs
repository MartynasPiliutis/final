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
    public partial class VartuPaieska : Form
    {
        public VartuPaieska()
        {
            InitializeComponent();
            object[] theList = Program.gateRepository.GetAllGateNameAndCodeArrayV2();
            vfind_dropbox_idList.Items.AddRange(theList);
        }

        private void vfind_button_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Vartai vartai = new Vartai();
            vartai.ShowDialog();
            this.Close();
        }

        private void vfind_button_find_Click(object sender, EventArgs e)
        {
            vfind_textbox_output.Items.Clear();

            string vartai = Program.gateRepository.GetGateCodeByID(Convert.ToInt32(vfind_dropbox_idList.SelectedItem));
            vfind_textbox_output.Items.Add($"Vartų ID: {Convert.ToInt32(vfind_dropbox_idList.SelectedItem)}");
            vfind_textbox_output.Items.Add($"Vartų vardas: {vartai}");
        }
    }
}
