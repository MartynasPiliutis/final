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
    public partial class PraejimasTestas : Form
    {
        public PraejimasTestas()
        {
            InitializeComponent();
            test_button_ok.Hide();
            test_light_red.BackColor = Color.LightGray;
            test_light_green.BackColor = Color.LightGray;

            object[] theListEmloyeeID = Program.employeeRepository.GetAllEmployeeId();
            test_dropbox_employeeidList.Items.AddRange(theListEmloyeeID);

            object[] theListGateId = Program.gateRepository.GetAllGateNameAndCodeArrayV2();
            test_dropbox_gateidList.Items.AddRange(theListGateId);
        }

        private void test_button_test_Click(object sender, EventArgs e)
        {
            test_light_red.BackColor = Color.LightGray;
            test_light_green.BackColor = Color.LightGray;
            int testEmployeeId = Convert.ToInt32(test_dropbox_employeeidList.SelectedItem);
            int testGateId = Convert.ToInt32(test_dropbox_gateidList.SelectedItem);
            bool light = Program.eventController.TryPass(testEmployeeId, testGateId);
            if (light == true)
            {
                test_light_green.BackColor = Color.Green;
            }
            else
            {
                test_light_red.BackColor = Color.Red;
            }
            Employee employee = Program.employeeRepository.GetEmployeeById(testEmployeeId);
            Program.eventRepository.SaveTryPass(testEmployeeId, testGateId, employee);
            test_button_back.Enabled = false;
            test_dropbox_employeeidList.Enabled = false;
            test_dropbox_gateidList.Enabled = false;
            test_button_test.Hide();
            test_button_ok.Show();
            test_button_test.Enabled = false;
            test_button_ok.Enabled = true;
        }

        private void test_button_back_Click(object sender, EventArgs e)
        {
            Vartai vartai = new Vartai();
            this.Hide();
            vartai.ShowDialog();
            this.Close();
        }

        private void test_button_ok_Click(object sender, EventArgs e)
        {
            test_button_back.Enabled = true;
            test_dropbox_employeeidList.Enabled = true;
            test_dropbox_gateidList.Enabled = true;
            test_light_red.BackColor = Color.LightGray;
            test_light_green.BackColor = Color.LightGray;
            test_button_test.Show();
            test_button_ok.Hide();
            test_button_test.Enabled = true;
            test_button_ok.Enabled = false;
            test_dropbox_employeeidList.Items.Clear();
            object[] theListEmloyeeID = Program.employeeRepository.GetAllEmployeeId();
            test_dropbox_employeeidList.Items.AddRange(theListEmloyeeID);
            test_dropbox_gateidList.Items.Clear();
            object[] theListGateId = Program.gateRepository.GetAllGateNameAndCodeArrayV2();
            test_dropbox_gateidList.Items.AddRange(theListGateId);
        }
    }
}
