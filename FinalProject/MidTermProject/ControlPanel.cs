using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MidTermProject
{
    public partial class ControlPanel : Form
    {
        public ControlPanel()
        {
            InitializeComponent();
        }

        private void btnAddPlayer_Click(object sender, EventArgs e)
        {
            // Create an instance of a form
            Form1 temp = new Form1();

            // Make it visible/active
            temp.Show();
        }

        private void btnSearchAppointments_Click(object sender, EventArgs e)
        {
            // Create an instance of a form
            AppointmentSearch temp = new AppointmentSearch();

            // Make it visible/active
            temp.ShowDialog();
        }

        private void btnAddAppointment_Click_1(object sender, EventArgs e)
        {
            // Create an instance of a form
            AppointmentMgr temp = new AppointmentMgr();

            // Make it visible/active
            temp.Show();
        }

        private void btnUpdateAppointments_Click(object sender, EventArgs e)
        {
            // Create an instance of a form
            AppointmentSearch temp = new AppointmentSearch();

            // Make it visible/active
            temp.ShowDialog();
        }

        private void btnDeleteAppointments_Click(object sender, EventArgs e)
        {
            // Create an instance of a form
            AppointmentSearch temp = new AppointmentSearch();

            // Make it visible/active
            temp.ShowDialog();
        }
    }
}
