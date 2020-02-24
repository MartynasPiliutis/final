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
    public partial class Vartai : Form
    {
        public Vartai()
        {
            InitializeComponent();
        }

        private void gates_button_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Pagrindinis main = new Pagrindinis();
            main.ShowDialog();
            this.Close();
        }

        private void gates_button_rasti_Click(object sender, EventArgs e)
        {
            this.Hide();
            VartuPaieska vartuPaieska = new VartuPaieska();
            vartuPaieska.ShowDialog();
            this.Close();
        }

        private void gates_button_add_Click(object sender, EventArgs e)
        {
            this.Hide();
            NaujiVartai naujiVartai = new NaujiVartai();
            naujiVartai.ShowDialog();
            this.Close();
        }

        private void gates_button_remove_Click(object sender, EventArgs e)
        {
            this.Hide();
            TrintiPraejima trintiPraejima = new TrintiPraejima();
            trintiPraejima.ShowDialog();
            this.Close();
        }
    }
}
