﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Default Zip Code to a local address
            txtZipCode.Text = "02818";

            // Hide Employee Labels & TextBoxes unless 
            lblEmployeeID.Visible = false;
            txtEmployeeID.Visible = false;
            lblHourlyRate.Visible = false;
            txtHourlyRate.Visible = false;
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
                txtEmployeeID.Visible = true;
                lblHourlyRate.Visible = true;
                txtHourlyRate.Visible = true;
            }
            else
            {
                lblEmployeeID.Visible = false;
                txtEmployeeID.Visible = false;
                lblHourlyRate.Visible = false;
                txtHourlyRate.Visible = false;
            }
        }
    }
}
