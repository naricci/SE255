using System;
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
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // Create instance of Person class called Nick
            Person Nick = new Person();

            // Fill in from Form
            Nick.FName = txtFName.Text;
            Nick.MName = txtMName.Text;
            Nick.LName = txtLName.Text;
            Nick.Street1 = txtStreet1.Text;
            Nick.Street2 = txtStreet2.Text;
            Nick.City = txtCity.Text;
            Nick.State = txtState.Text;
            Nick.Zipcode = txtZipCode.Text;
            Nick.Country = txtCountry.Text;
            Nick.Phone = txtPhone.Text;
            Nick.Email = txtEmail.Text;

            // Alternate method to create instance of Person Class
            Person temp = new Person(txtFName.Text, txtMName.Text, txtLName.Text, txtStreet1.Text, txtStreet2.Text, txtCity.Text, txtState.Text, txtZipCode.Text, txtCountry.Text, txtPhone.Text, txtEmail.Text);

            if (temp.Feedback.Contains("ERROR:"))
            {
                lblFeedback.Text = temp.Feedback;
            }
            else
            {
                FillLabel(temp);
                // lblFeedback.Text = temp.AddPerson();   // Lab 4
            }
        }

        public void FillLabel(Person temp)
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
    }
}
