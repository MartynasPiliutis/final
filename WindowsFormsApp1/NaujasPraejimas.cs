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
    }
}
