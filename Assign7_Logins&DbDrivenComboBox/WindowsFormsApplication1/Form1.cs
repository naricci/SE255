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

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        // Variables
        string workstatus = "";

        public Form1()
        {
            InitializeComponent();
            // Default Zip Code to a local address
            txtZipCode.Text = "02818";

            // Default Hourly Rate to minimum wage
            txtHourlyRate.Text = "10";

            btnDelete.Visible = false;
            btnUpdate.Visible = false;
            btnSubmit.Visible = true;
            FillStates();

            /*************************************************************
             * Extra-Credit:    Fill in the ComboBox    *****************/
            //FillPersons();
            /************************************************************/


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

            /*************************************************************
             * Extra-Credit:    Fill in the ComboBox    *****************/
            //FillPersons();
            /************************************************************/

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
                // Select the appropriate State for this person
                cmbState.SelectedItem = dr["State"].ToString();
                txtZipCode.Text = dr["Zipcode"].ToString();
                txtCountry.Text = dr["Country"].ToString();
                txtPhone.Text = dr["Phone"].ToString();
                txtEmail.Text = dr["Email"].ToString();
                // We added this one to store the ID in a new label
                lblPerson_ID.Text = dr["Person_ID"].ToString();
                /*
                bool blnFound = false;
                int intIndex = 0;
                while (blnFound == false)
                {
                    if (((ComboBoxItem)cmbWho.Items[intIndex]).Value == intPerson_ID)
                    {
                        blnFound = true;
                        cmbWho.SelectedIndex = intIndex;
                    }
                    intIndex++;
                }
                */
            }
            chkEmployee.Visible = false;
            chkEmployee.Checked = false;
            lblEmployeeID.Visible = false;
            txtEmployeeID.Visible = false;
            lblHourlyRate.Visible = false;
            txtHourlyRate.Visible = false;
            btnSubmit.Visible = false;
        }
        

        private void FillStates()
        {
            // Get the list of States in the DataReader
            SqlDataReader dr = MyUtilities.GetMyStates();

            // loop through each State
            while (dr.Read())
            {
                // for each state, add it to the ComboBox
                cmbState.Items.Add(dr["State"]).ToString();
            }

            cmbState.Items.Insert(0, "Please choose one...");
            cmbState.SelectedIndex = 0;
            dr.Close();
        }


        /*************************************************************
         * Extra-Credit:    Fill in the ComboBox with ComboBoxItem's
         * representing each of the people in the Persons Table ******
         ************************************************************/
         /*
        private void FillPersons()
        {
            // Get the list of people in the DataReader
            SqlDataReader dr = Person.GetMyPeople();

            // Loop through each Person record...
            while (dr.Read())
            {
                // Build a ComboBoxItem
                ComboBoxItem item = new ComboBoxItem();
                // Fill it's Text and Value properties
                item.Text = dr["LName"].ToString() + ", " + dr["FName"].ToString();
                item.Value = Convert.ToInt32(dr["Person_ID"].ToString());

                // Add the ComboBoxItem to the ComboBox
                cmbWho.Items.Add(item);
            }
            dr.Close();

            // Now that ComboBox is filled with Person(s)
            // Build another ComoboBoxItem and make it our default
            ComboBoxItem temp = new ComboBoxItem();
            temp.Text = "Please choose one...";
            temp.Value = 0;
            cmbWho.Items.Insert(0, temp);
            cmbWho.SelectedIndex = 0;
        }
        */
        /*************************************************************
         ************************************************************/
        

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
                    lblFeedback.Text += "ERROR: Please fill in an Hourly Wage greater than or equal to 10.\n";
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
                // string FName, LName, MName;
                // Declaration
                Employee temp;  // Equivalent to Clearing land and putting foundation
                // Instantiation: Building the framework for house
                temp = new Employee();

                // Create instance of Employee class called temp    // old version
                // Employee temp = new Employee();  // old version

                // Fill in from Form Data
                temp.FName = txtFName.Text;
                temp.MName = txtMName.Text;
                temp.LName = txtLName.Text;
                temp.Street1 = txtStreet1.Text;
                temp.Street2 = txtStreet2.Text;
                temp.City = txtCity.Text;
                temp.State = cmbState.SelectedItem.ToString();
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
                else if (temp.FName.Length > 0 && temp.LName.Length > 0)
                {
                    DisplayInfo(temp);
                    temp.AddPerson();
                }
                else
                {
                    DisplayInfo();
                }

                /************************** old **************************
                else if (chkEmployee.Checked == true)
                {
                    lblFeedback.Text = temp.AddEmployee();
                }
                else
                {
                    lblFeedback.Text = temp.AddPerson();
                }
                 ************************** old *************************/
            }
        }


        /* FUNCTION OVERLOADING - 2 or More functions with the same name
         * but with different # of params, types of params, or sequence */
         private void DisplayInfo(Person temp)
        {
            lblFeedback.Text = temp.FName + " " + temp.MName + " " + temp.LName;
        }


        private void Form1_Load(object sender, EventArgs e)
        {

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

            // Reset ComboBoxes
            cmbState.SelectedIndex = 0;
            cmbWho.SelectedIndex = 0;
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


        private void btnSearch_Click(object sender, EventArgs e)
        {
            PersonSearch temp = new PersonSearch();
            temp.ShowDialog();
        }


        private void DisplayInfo()
        {
            lblFeedback.Text = "Unknown Person....Lack of Data";
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            Person temp = new Person();
            
            Int32 intPerson_ID = Convert.ToInt32(lblPerson_ID.Text);
            Int32 intRecords = temp.DeleteOnePerson(intPerson_ID);
            lblFeedback.Text = intRecords.ToString() + " Records Deleted.";
            this.Close();
            
            //lblFeedback.Text =
            //  temp.DeleteOnePerson(Convert.ToInt32(lblPerson_ID.Text));
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // string FName, LName, MName;
            // Declaration
            Person temp;
            // Instantiation
            temp = new Person();

            //Person temp = new Person();
            temp.FName = txtFName.Text;
            temp.MName = txtMName.Text;
            temp.LName = txtLName.Text;
            temp.Street1 = txtStreet1.Text;
            temp.Street2 = txtStreet2.Text;
            temp.City = cmbState.SelectedItem.ToString();
            temp.State = txtState.Text;
            temp.Zipcode = txtZipCode.Text;
            temp.Country = txtCountry.Text;
            temp.Phone = txtPhone.Text;
            temp.Email = txtEmail.Text;
            //temp.Employed = workstatus;
            //temp.EmployeeID = txtEmployeeID.Text;
            //temp.HourlyRate = double.Parse(txtHourlyRate.Text);

            temp.Person_ID = Convert.ToInt32(lblPerson_ID.Text);

            if (temp.Feedback.Contains("ERROR:"))
            {
                lblFeedback.Text = temp.Feedback;
            }
            else if (temp.FName.Length > 0 && temp.LName.Length > 0)
            {
                DisplayInfo(temp);
                Int32 intRecords = temp.UpdateAContact();

                lblFeedback.Text = intRecords.ToString() + " records updated.";
                this.Close();
                //temp.UpdateAContact( Convert.ToInt32(lblPerson_ID.Text) );
            }
            else
            {
                DisplayInfo();
            }
        }


        /*************************************************************************
         * Extra-Credit:    Display the Person_ID of the Person chosen in ComboBox
         * ***********************************************************************/
         private void cmbWho_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show((cmbWho.SelectedItem as ComboBoxItem).Value.ToString());
        }
    }
}
