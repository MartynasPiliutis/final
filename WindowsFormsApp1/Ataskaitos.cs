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
    public partial class Ataskaitos : Form
    {
        public Ataskaitos()
        {
            InitializeComponent();
        }

        private void main_button_vartai_Click(object sender, EventArgs e)
        {

        }

        private void report_button_vartai_Click(object sender, EventArgs e)
        {

        }

        private void report_button_all_Click(object sender, EventArgs e)
        {
            AtaskaitosVisi ataskaitosVisi = new AtaskaitosVisi();
            this.Hide();
            ataskaitosVisi.ShowDialog();
            this.Close();
        }

        private void main_button_exit_Click(object sender, EventArgs e)
        {

        }
    }
}
