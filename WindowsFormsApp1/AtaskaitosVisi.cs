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
    public partial class AtaskaitosVisi : Form
    {
        public AtaskaitosVisi()
        {
            InitializeComponent();
        }

        private void reportAll_button_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ataskaitos ataskaitos = new Ataskaitos();
            ataskaitos.ShowDialog();
            this.Close();
        }

        private void FiltrasAll_Enter(object sender, EventArgs e)
        {

        }

        private void check_filter_All_CheckedChanged(object sender, EventArgs e)
        {
            reportAll_button_filtruoti.Enabled = true;
        }

        private void check_filter_true_CheckedChanged(object sender, EventArgs e)
        {
            reportAll_button_filtruoti.Enabled = true;
        }

        private void check_filter_false_CheckedChanged(object sender, EventArgs e)
        {
            reportAll_button_filtruoti.Enabled = true;
        }

        private void reportAll_button_filtruoti_Click(object sender, EventArgs e)
        {
            if (check_filter_All.Checked == true)
            {
                Ataskaita_Visi ataskaita = new Ataskaita_Visi();
                ataskaita.ShowDialog();
            }
            else if (check_filter_true.Checked == true)
            {
                Ataskaita_True ataskaitaTrue = new Ataskaita_True();
                ataskaitaTrue.ShowDialog();
            }
            else if (check_filter_false.Checked == true)
            {
                Ataskaita_False ataskaitaFalse = new Ataskaita_False();
                ataskaitaFalse.ShowDialog();
            }
        }
    }
}
