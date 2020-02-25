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
            Pagrindinis main = new Pagrindinis();
            this.Hide();
            main.ShowDialog();
            this.Close();
        }

        private void gates_button_rasti_Click(object sender, EventArgs e)
        {
            VartuPaieska vartuPaieska = new VartuPaieska();
            this.Hide();
            vartuPaieska.ShowDialog();
            this.Close();
        }

        private void gates_button_add_Click(object sender, EventArgs e)
        {
            NaujiVartai naujiVartai = new NaujiVartai();
            this.Hide();
            naujiVartai.ShowDialog();
            this.Close();
        }

        private void gates_button_remove_Click(object sender, EventArgs e)
        {
            TrintiPraejima trintiPraejima = new TrintiPraejima();
            this.Hide();
            trintiPraejima.ShowDialog();
            this.Close();
        }

        private void gates_button_test_Click(object sender, EventArgs e)
        {
            PraejimasTestas praejimasTestas = new PraejimasTestas();
            this.Hide();
            praejimasTestas.ShowDialog();
            this.Close();
        }
    }
}
