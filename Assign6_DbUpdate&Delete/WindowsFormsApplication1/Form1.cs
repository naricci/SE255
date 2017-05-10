using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;        // Library to connect to SQL Server

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        // Global variables
        bool isEmployee = false;

        public Form1()
        {
            InitializeComponent();

            // Default Zip Code to a local address
            txtZipCode.Text = "02818";

            // Default Hourly Rate to minimum wage
            txtHourlyRate.Text = "10";

            // Hide Employee Labels & TextBoxes unless 
            lblEmployeeID.Visible = false;
            lblEmployeeID.Enabled = false;
            txtEmployeeID.Visible = false;
            txtEmployeeID.Enabled = false;
            lblHourlyRate.Visible = false;
            lblHourlyRate.Enabled = false;
            txtHourlyRate.Visible = false;
            txtHourlyRate.Enabled = false;

            //Disable Edit and Delete capability because they do not exist
            btnUpdate.Visible = false;
            btnUpdate.Enabled = false;
            btnDelete.Visible = false;
            btnDelete.Enabled = false;
        }

        // OVERLOADED CONSTRUCTOR - Meant to pull in existing data
        public Form1(Int32 intPerson_ID)
        {
            InitializeComponent();

            // Disable Add capability because they already exist
            btnSubmit.Visible = false;
            btnSubmit.Enabled = false;

            // Gather info about this one person and store it in a datareader
            Person temp = new Person();
            SqlDataReader dr = temp.FindOnePerson(intPerson_ID);

            /**
             * Use that info to fill out the form
             * Loop thru the records stored in the reader 1 record at a time
             * Note that since this is based on one person's ID, then we 
             * should only have one record 
             */
            while (dr.Read())
            {
                // Take the Name(s) from the DataReader and copy them
                // into the appropriate text fields
                txtFName.Text = dr["FName"].ToString();
                txtMName.Text = dr["MName"].ToString();
                txtLName.Text = dr["LName"].ToString();
                
                // We added this one to store the ID in a new label
                lblPerson_ID.Text = dr["Person_ID"].ToString();
            }
            
            // Default Zip Code to a local address
            txtZipCode.Text = "02818";

            // Default Hourly Rate to minimum wage
            txtHourlyRate.Text = "10";

            // Hide/Disable Employee Labels & TextBoxes unless 
            lblEmployeeID.Visible = false;
            lblEmployeeID.Enabled = false;
            txtEmployeeID.Visible = false;
            txtEmployeeID.Enabled = false;
            lblHourlyRate.Visible = false;
            lblHourlyRate.Enabled = false;
            txtHourlyRate.Visible = false;
            txtHourlyRate.Enabled = false;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // Create instance of Employee class called temp
            Employee temp = new Employee();

            // Fill in from Form Data
            temp.FName = txtFName.Text;
            temp.MName = txtMName.Text;
            temp.LName = txtLName.Text;
            temp.Street1 = txtStreet1.Text;
            temp.Street2 = txtStreet2.Text;
            temp.City = txtCity.Text;
            temp.State = txtState.Text;
            temp.Zipcode = txtZipCode.Text;
            temp.Country = txtCountry.Text;
            temp.Phone = txtPhone.Text;
            temp.Email = txtEmail.Text;
            temp.EmployeeID = txtEmployeeID.Text;
            temp.HourlyRate = double.Parse(txtHourlyRate.Text);
            

            if (temp.Feedback.Contains("ERROR:"))
            {
                lblFeedback.Text = temp.Feedback;
            }
            else if (chkEmployee.Checked == true)
            {
                // FillLabel(temp);
                lblFeedback.Text = temp.AddEmployee();
            }
            else
            {
                // FillLabel(temp);
                lblFeedback.Text = temp.AddPerson();
            }
        }

        public void FillLabel(Employee temp)
        {
            lblFeedback.Text = temp.FName + "\n";
            lblFeedback.Text += temp.MName + "\n";
            lblFeedback.Text += temp.LName + "\n";
            lblFeedback.Text += temp.Street1 + "\n";
            lblFeedback.Text += temp.Street2 + "\n";
            lblFeedback.Text += temp.City + "\n";
            lblFeedback.Text += temp.State + "\n";
            lblFeedback.Text += temp.Zipcode + "\n";
            lblFeedback.Text += temp.Country + "\n";
            lblFeedback.Text += temp.Phone + "\n";
            lblFeedback.Text += temp.Email + "\n";

            lblFeedback.Text += temp.EmployeeID + "\n";
            lblFeedback.Text += temp.HourlyRate + "\n";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Loop to clear data from the form
            foreach (var c in this.Controls)
            {
                // Clear the TextBoxes
                if (c is TextBox)
                {
                    ((TextBox)c).Text = String.Empty;
                }
            }

            // Clear Feedback Label
            lblFeedback.Text = "Feedback";
        }

        private void chkEmployee_CheckedChanged(object sender, EventArgs e)
        {
            // Show/Hide Employee ID textfield if Person is Employee
            if (chkEmployee.Checked == true)
            {
                lblEmployeeID.Visible = true;
                lblEmployeeID.Enabled = true;
                txtEmployeeID.Visible = true;
                txtEmployeeID.Enabled = true;
                lblHourlyRate.Visible = true;
                lblHourlyRate.Enabled = true;
                txtHourlyRate.Visible = true;
                txtHourlyRate.Enabled = true;
            }
            else
            {
                lblEmployeeID.Visible = false;
                lblEmployeeID.Enabled = false;
                txtEmployeeID.Visible = false;
                txtEmployeeID.Enabled = false;
                lblHourlyRate.Visible = false;
                lblHourlyRate.Enabled = false;
                txtHourlyRate.Visible = false;
                txtHourlyRate.Enabled = false;
            }
        }
    }
}
