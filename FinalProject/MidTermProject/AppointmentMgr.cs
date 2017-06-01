using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MidTermProject
{
    public partial class AppointmentMgr : Form
    {
        public AppointmentMgr()
        {
            InitializeComponent();
            btnUpdate.Visible = false;
            btnDelete.Visible = false;
        }

        // OVERLOADED CONSTRUCTOR - Meant to pull in existing data
        public AppointmentMgr(Int32 intAppointment_ID)
        {
            InitializeComponent();
            btnAdd.Visible = false;
            btnUpdate.Visible = true;
            btnDelete.Visible = true;

            Appointment temp = new Appointment();
            SqlDataReader dr = temp.FindOneAppointment(intAppointment_ID);

            while (dr.Read())
            {
                dtpStartDate.Text = dr["StartDate"].ToString();
                dtpEndDate.Text = dr["EndDate"].ToString();
                txtFirstName.Text = dr["FirstName"].ToString();
                txtLastName.Text = dr["LastName"].ToString();
                txtLocation.Text = dr["Location"].ToString();
                txtComments.Text = dr["Comments"].ToString();
                lblAppointment_ID.Text = dr["Appointment_ID"].ToString();
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Clear Feedback Label
            lblFeedback.Text = "";

            Appointment meeting = new Appointment();

            meeting.StartDate = dtpStartDate.Value;
            meeting.EndDate = dtpEndDate.Value;
            meeting.FirstName = txtFirstName.Text;
            meeting.LastName = txtLastName.Text;
            meeting.Location = txtLocation.Text;
            meeting.Comments = txtComments.Text;

            // Display Errors or Results in Feedback Label
            if (meeting.Feedback.Contains("ERROR:"))
            {
                lblFeedback.Text = meeting.Feedback;
            }
            else
            {
                lblFeedback.Text = meeting.AddAppointment();
            }
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            Appointment meeting = new Appointment();

            Int32 intAppointment_ID = Convert.ToInt32(lblAppointment_ID.Text);
            Int32 intRecords = meeting.DeleteOneAppointment(intAppointment_ID);
            lblFeedback.Text = intRecords.ToString() + " Appointment Deleted.";
            this.Close();
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            Appointment meeting = new Appointment();
            meeting.StartDate = dtpStartDate.Value;
            meeting.EndDate = dtpEndDate.Value;
            meeting.FirstName = txtFirstName.Text;
            meeting.LastName = txtLastName.Text;
            meeting.Location = txtLocation.Text;
            meeting.Comments = txtComments.Text;
            meeting.Appointment_ID = Convert.ToInt32(lblAppointment_ID.Text);

            if (meeting.Feedback.Contains("ERROR:"))
            {
                lblFeedback.Text = meeting.Feedback;
            }
            else if (meeting.FirstName.Length > 0 && meeting.LastName.Length > 0)
            {
                Int32 intRecords = meeting.UpdateAnAppointment();

                lblFeedback.Text = intRecords.ToString() + " Appointment Updated.";
                //this.Close();
            }
            else
            {
            }
        }
    }
}
