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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Initialize Player Age to 18 years old, minimum age required to play in NHL
            // txtAge.Text = "18";
            int ageConv = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Populate Position ComboBox
            cmbPosition.Items.Add("Pick a Position...");
            cmbPosition.Items.Add("Center");
            cmbPosition.Items.Add("Left Wing");
            cmbPosition.Items.Add("Right Wing");
            cmbPosition.Items.Add("Left Defenseman");
            cmbPosition.Items.Add("Right Defenseman");
            
            // Populate Shot ComboBox
            cmbShot.Items.Add("Pick a Shot...");
            cmbShot.Items.Add("Left");
            cmbShot.Items.Add("Right");

            // Set Default Settings
            cmbPosition.SelectedIndex = 0;
            cmbShot.SelectedIndex = 0;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // Set DTP to a variable
            DateTime dtBday = new DateTime();
            dtBday = dtpBirthday.Value;

            /*
            // Set Age to a variable
            int playerAge = new int();
            playerAge = Convert.ToInt32(txtAge.Text);
            */
            int ageConv = int.Parse(txtAge.Text);

            // Create instance of Employee class called temp
            Player temp = new Player();
            
            // Fill in from Form Data
            temp.FirstName = txtFirstName.Text;
            temp.LastName = txtLastName.Text;
            temp.Age = ageConv;
            temp.Birthday = dtBday;
            temp.JerseyNum = int.Parse(txtJersey.Text);
            temp.Position = cmbPosition.SelectedItem.ToString();
            temp.Shot = cmbShot.SelectedItem.ToString();
            temp.Goals = int.Parse(txtGoals.Text);
            temp.Assists = int.Parse(txtAssists.Text);
            temp.Notes = txtNotes.Text;

            if (temp.Feedback.Contains("ERROR:"))
            {
                lblFeedback.Text = temp.Feedback;
            }
            else
            {
                // Display Output
                lblFeedback.Text = temp.AddPlayer();
                // Contact Label
                lblPlayer.Text += temp.FirstName + " " + temp.LastName;     
                // Contact ListBox
                lbxContact.Items.Add(temp.FirstName + " " + temp.LastName);
                lbxContact.Items.Add(ageConv);
                lbxContact.Items.Add(dtBday);
                lbxContact.Items.Add(temp.JerseyNum);
                lbxContact.Items.Add(temp.Position);
                lbxContact.Items.Add(temp.Shot);
                lbxContact.Items.Add(temp.Goals);
                lbxContact.Items.Add(temp.Assists);
                lbxContact.Items.Add(temp.Notes);
            }
        }

        public void FillLabel(Player temp)
        {
            lblFeedback.Text =  temp.FirstName + "\n";
            lblFeedback.Text += temp.LastName + "\n";
            lblFeedback.Text += temp.Age + "\n";
            lblFeedback.Text += temp.Birthday + "\n";
            lblFeedback.Text += temp.JerseyNum + "\n";
            lblFeedback.Text += temp.Position + "\n";
            lblFeedback.Text += temp.Shot + "\n";
            lblFeedback.Text += temp.Goals + "\n";
            lblFeedback.Text += temp.Assists + "\n";
            lblFeedback.Text += temp.Notes + "\n";
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
                // Clear the DTPs
                
                else if (c is DateTimePicker)
                {
                    ((DateTimePicker)c).Text = String.Empty;
                }
            }

            // Reset ComboBoxes
            cmbPosition.SelectedIndex = 0;
            cmbShot.SelectedIndex = 0;

            // Clear Feedback Label
            lblFeedback.Text = "Feedback";

            // Reset Contact Label
            lblPlayer.Text = "Player: ";
        }
    }
}
