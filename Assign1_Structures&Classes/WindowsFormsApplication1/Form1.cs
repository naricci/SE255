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
        public struct Person
        {
            public string FName;
            public string MName;
            public string LName;
            public string Street1;
            public string Street2;
            public string City;
            public string State;
            public string ZipCode;
            public string Phone;
            public string Email;
        };

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Person Nick = new Person();
            Nick.FName = txtFName.Text;
            Nick.MName = txtMName.Text;
            Nick.LName = txtLName.Text;
            Nick.Street1 = txtStreet1.Text;
            Nick.Street2 = txtStreet2.Text;
            Nick.City = txtCity.Text;
            Nick.State = txtState.Text;
            Nick.ZipCode = txtZipCode.Text;
            Nick.Phone = txtPhone.Text;
            Nick.Email = txtEmail.Text;

            FillLabel(Nick);
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
            lblFeedback.Text += temp.ZipCode + "\n";
            lblFeedback.Text += temp.Phone + "\n";
            lblFeedback.Text += temp.Email + "\n";
        }
    }
}
