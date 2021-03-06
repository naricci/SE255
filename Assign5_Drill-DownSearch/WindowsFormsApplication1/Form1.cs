﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        string workstatus = "";

        public Form1()
        {
            InitializeComponent();
            // Default Zip Code to a local address
            txtZipCode.Text = "02818";

            // Default Hourly Rate to minimum wage
            txtHourlyRate.Text = "10";

            // Hide Employee Labels & TextBoxes unless 
            //lblEmployeeID.Visible = false;
            //lblEmployeeID.Enabled = false;
            //txtEmployeeID.Visible = false;
            //txtEmployeeID.Enabled = false;
            //lblHourlyRate.Visible = false;
            //lblHourlyRate.Enabled = false;
            //txtHourlyRate.Visible = false;
            //txtHourlyRate.Enabled = false;
        }

        // OVERLOADED CONSTRUCTOR - Meant to pull in existing data
        public Form1(Int32 intPerson_ID)
        {
            InitializeComponent();

            //chkEmployee.Checked = true;
            txtEmployeeID.Visible = true;
            txtHourlyRate.Visible = true;
            
            
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
                txtStreet1.Text = dr["Street1"].ToString();
                txtStreet2.Text = dr["Street2"].ToString();
                txtCity.Text = dr["City"].ToString();
                txtState.Text = dr["State"].ToString();
                txtZipCode.Text = dr["ZipCode"].ToString();
                txtCountry.Text = dr["Country"].ToString();
                txtPhone.Text = dr["Phone"].ToString();
                txtEmail.Text = dr["Email"].ToString();
                
                // We added this one to store the ID in a new label
                lblPerson_ID.Text = dr["Person_ID"].ToString();
            }
            
        }
        

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            double hourlyrate = 10;

            // Make sure the feedback label is cleared from any previous attempts
            lblFeedback.Text = "";

            /************************* FORM VALIDATION *************************/
            bool isValid = true;

            // First Name Form Validation
            if (ValidationLibrary.IsItFilledIn(txtFName.Text, 1) == false)
            {
                lblFeedback.Text += "ERROR: Please fill in a First Name.\n";
                isValid = false;
            }

            // Last Name Form Validation
            if (ValidationLibrary.IsItFilledIn(txtLName.Text, 1) == false)
            {
                lblFeedback.Text += "ERROR: Please fill in a Last Name.\n";
                isValid = false;
            }

            // State Form Validation
            if (ValidationLibrary.IsItFilledIn(txtState.Text, 2) == false)
            {
                lblFeedback.Text += "ERROR: Please fill in a 2-digit State abbreviation.\n";
                isValid = false;
            }
            else if (ValidationLibrary.IsValidLength(txtState.Text, 2) == false)
            {
                lblFeedback.Text += "ERROR: Please make sure State abbreviation is exactly 2-digits.\n";
                isValid = false;
            }
            else if (txtState.Text.All(Char.IsLetter) == false)
            {
                lblFeedback.Text += "ERROR: Please make sure State abbreviation only contains letters.\n";
                isValid = false;
            }

            // Zip Code Form Validation
            if (ValidationLibrary.IsItFilledIn(txtZipCode.Text, 5) == false)
            {
                lblFeedback.Text += "ERROR: Please fill in a 5-digit Zip Code.\n";
                isValid = false;
            }
            else if (ValidationLibrary.IsAllDigits(txtZipCode.Text) == false)
            {
                lblFeedback.Text += "ERROR: Please make sure Zip Code contains numbers only.\n";
                isValid = false;
            }

            // Email Form Validation
            if (ValidationLibrary.IsItFilledIn(txtEmail.Text) == false)
            {
                lblFeedback.Text += "ERROR: Please fill in a valid Email address.\n";
                isValid = false;
            }
            else if (ValidationLibrary.IsValidEmail(txtEmail.Text) == false)
            {
                lblFeedback.Text += "ERROR: Please fill in a valid Email address.\n";
                isValid = false;
            }

            if (chkEmployee.Checked == true)
            {
                // Employee ID Form Validation
                if (ValidationLibrary.IsItFilledIn(txtEmployeeID.Text, 1) == false)
                {
                    lblFeedback.Text += "ERROR: Please fill in an Employee ID...Numbers Only!\n";
                    isValid = false;
                }
                else if (txtEmployeeID.Text.All(Char.IsNumber) == false)
                {
                    lblFeedback.Text += "ERROR: Please make sure Employee ID contains numbers only.\n";
                    isValid = false;
                }

                // Hourly Rate Form Validation
                if (txtHourlyRate.Text.Length < 2)
                {
                    lblFeedback.Text += "ERROR: Please fill in an Hourly Wage greate than or equal to 10.\n";
                    isValid = false;
                }
                else
                {
                    bool isNum = double.TryParse(txtHourlyRate.Text, out hourlyrate) == true;

                    if (isNum == true)
                    {

                    }
                    else
                    {
                        lblFeedback.Text += "ERROR: Please make sure that Hourly Wage is greater than or equal to 10.\n";
                        isValid = false;
                    }
                }
            }

            if (isValid)
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
                temp.Employed = workstatus;
                temp.EmployeeID = txtEmployeeID.Text;
                temp.HourlyRate = double.Parse(txtHourlyRate.Text);

                // Display Errors or Results in Feedback Label
                if (temp.Feedback.Contains("ERROR:"))
                {
                    lblFeedback.Text = temp.Feedback;
                }
                else if (chkEmployee.Checked == true)
                {
                    lblFeedback.Text = temp.AddEmployee();
                }
                else
                {
                    lblFeedback.Text = temp.AddPerson();
                }
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

            // Filled only if Person is also Employee
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
            lblFeedback.Text = "";

            // Clear Checkboxes
            chkEmployee.Checked = false;
        }

        
        private void chkEmployee_CheckedChanged(object sender, EventArgs e)
        {
            if (chkEmployee.Checked == true)
            {
                workstatus = "YES";
            }
            else
            {
                workstatus = "NO";
            }
        }
       
    }
}
