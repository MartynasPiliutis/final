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
    public partial class Pagrindinis : Form
    {

        public Pagrindinis()
        {
            InitializeComponent();
        }

        private void main_button_darbuotojai_Click(object sender, EventArgs e)
        {
            
            Darbuotojai employee = new Darbuotojai();
            this.Hide();
            employee.ShowDialog();
            this.Close();
        }

        private void main_button_exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void main_button_vartai_Click(object sender, EventArgs e)
        {
            Vartai vartai = new Vartai();
            this.Hide();
            vartai.ShowDialog();
            this.Close();
        }
    }
}
