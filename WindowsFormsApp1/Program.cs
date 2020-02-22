using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using PCMLibrary;

namespace PCMSystem
{
    static class Program
    {
        public static EmployeeRepository employeeRepository = new EmployeeRepository();
        public static GateRepository gateRepository = new GateRepository();
        public static EventRepository eventRepository = new EventRepository();


        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Pagrindinis());

            
        }
    }
}
