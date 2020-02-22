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
    public partial class DarbuotojuPaieska : Form
    {
        public DarbuotojuPaieska()
        {
            InitializeComponent();
        }

        private void dfind_dropbox_idList_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine("vienas");
            Console.WriteLine("du");
        }

        private void dfind_button_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Darbuotojai darbuotojai = new Darbuotojai();
            darbuotojai.ShowDialog();
            this.Close();
        }
    }
}
