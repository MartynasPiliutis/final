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
    public partial class DarbuotojuPaieska : Form
    {
        public DarbuotojuPaieska()
        {
            InitializeComponent();

            EmployeeRepository employeeRepository = new EmployeeRepository();
            object[] theList = employeeRepository.GetAllEmployeeId();
            dfind_dropbox_idList.Items.AddRange(theList);
        }

        private void dfind_dropbox_idList_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void dfind_button_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Darbuotojai darbuotojai = new Darbuotojai();
            darbuotojai.ShowDialog();
            this.Close();
        }

        private void DarbuotojuPaieska_Load(object sender, EventArgs e)
        {

        }
    }
}
