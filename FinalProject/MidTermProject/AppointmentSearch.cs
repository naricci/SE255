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
    public partial class AppointmentSearch : Form
    {
        public AppointmentSearch()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Appointment temp = new Appointment();
      
            DataSet ds = temp.SearchAppointments(txtFirstName.Text, txtLastName.Text, txtLocation.Text);
            
            gvAppointments.DataSource = ds;                              
            gvAppointments.DataMember = ds.Tables["Appointments"].ToString(); 
        }

        private void gvAppointments_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string strAppointment_ID = gvAppointments.Rows[e.RowIndex].Cells[0].Value.ToString();

            int intAppointment_ID = Convert.ToInt32(strAppointment_ID);

            AppointmentMgr Editor = new AppointmentMgr(intAppointment_ID);
            this.Close();
            Editor.ShowDialog();
        }
    }
}
