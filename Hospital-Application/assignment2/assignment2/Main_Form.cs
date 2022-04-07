using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment2
{
    public partial class Main_Form : Form
    {
        public Main_Form()
        {
            InitializeComponent();
        }

        private void apToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Appointment_Management f3 = new Appointment_Management();
            f3.Show();
        }

        private void doctorManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Doctor_Management f1 = new Doctor_Management();
            f1.Show();
        }

        private void patientManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Patient_Management f2 = new Patient_Management();
            f2.Show();
        }

        private void managementSystemToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void consultationToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Main_Form_Load(object sender, EventArgs e)
        {

        }

        private void consultationToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Show_All f4 = new Show_All();
            f4.Show(); 
        }

        private void searchAppointmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Search_Appointment f5 = new Search_Appointment();
            f5.Show();
        }

        private void showPatientsAppointmentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Show_Appointment f6 = new Show_Appointment();
            f6.Show(); 
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Close(); 
            if(MessageBox.Show("Exit ?", "You're going to close the App", MessageBoxButtons.YesNo) == DialogResult.Yes)
            Close(); 

        }
    }
}
