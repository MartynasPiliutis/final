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
    public partial class Darbuotojai : Form
    {
        public Darbuotojai()
        {
            InitializeComponent();
        }

        private void Darbuotojai_Load(object sender, EventArgs e)
        {

        }

        private void darbuotojai_button_remove_Click(object sender, EventArgs e)
        {
            this.Hide();
            TrintiDarbuotoja trintiDarbuotoja = new TrintiDarbuotoja();
            trintiDarbuotoja.ShowDialog();
            this.Close();
        }

        private void darbuotojai_button_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Pagrindinis main = new Pagrindinis();
            main.ShowDialog();
            this.Close();
        }

        private void darbuotojai_button_rasti_Click(object sender, EventArgs e)
        {
            this.Hide();
            DarbuotojuPaieska darbuotojuPaieska = new DarbuotojuPaieska();
            darbuotojuPaieska.ShowDialog();
            this.Close();
        }

        private void darbuotojai_button_add_Click(object sender, EventArgs e)
        {
            this.Hide();
            NaujasDarbuotojas naujasDarbuotojas = new NaujasDarbuotojas();
            naujasDarbuotojas.ShowDialog();
            this.Close();
        }
    }
}
