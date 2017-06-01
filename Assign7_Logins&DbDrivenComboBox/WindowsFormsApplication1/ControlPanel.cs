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
    public partial class ControlPanel : Form
    {
        public ControlPanel()
        {
            InitializeComponent();
        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            // Create an instance of a form
            Form1 temp = new Form1();
            // Make it visible/active
            temp.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // Create an instance of a form
            PersonSearch temp = new PersonSearch();
            // Make it visible/active
            temp.ShowDialog();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Clear any previous feedback
            lblFeedback.Text = "";

            // Check to see if user/pw exists within DB table

            // If login is valid
            // Disable/Invisible Login Panel
            // Enable/Show the Controls Panel
            // 1 is highest admin and 10 is a basic user (5 and less is allowed access
            int intLevel = EmployeeLogin(txtUName.Text, txtPW.Text);
            if (intLevel < 5 && intLevel !=0)
            {
                // Make controls available
                pnlControls.Enabled = true;
                pnlControls.Visible = true;
                // Make Login unavailable
                pnlLogin.Enabled = false;
                pnlLogin.Visible = false;
            }
            // if invalid:
            // Display Invalid login message
            // Make sure Controls Panel is disabled
            else
            {
                // Make controls unavailable
                pnlControls.Enabled = false;
                pnlControls.Visible = false;
                // Make Login available
                pnlLogin.Enabled = true;
                pnlLogin.Visible = true;
                // Let user know login is invalid
                lblFeedback.Text = "Sorry...Invalid login";
            }
        }


        private int EmployeeLogin(string strUName, string strPW)
        {
            // Declare var to hold level
            int intAdminLevel = 0;

            // Create a DataReader to return filled
            SqlDataReader dr;

            // Create a command for our SQL statement
            SqlCommand comm = new SqlCommand();

            // Write a select Statement to perform Search
            String strSQL = "SELECT MyLevel FROM MyLogin WHERE (UName = @UName AND PW = @PW)";

            // Set Params
            comm.Parameters.AddWithValue("@UName", strUName);
            comm.Parameters.AddWithValue("@PW", strPW);


            // Create DB Tools and Configure
            /************************************************************************/
            SqlConnection conn = new SqlConnection();
            // Create the who, what, where of the DB
            string strConn = @"SQL.NEIT.EDU,4500;Database=SE255_NRicci;User Id = SE255_NRicci;Password=001405200;";
            conn.ConnectionString = strConn;

            // Fill in basic info to command object
            comm.Connection = conn;     // Tell the commander what connection to use
            comm.CommandText = strSQL;  // Tell the command what to say

            // Get Data
            conn.Open();                // Open the connection (pick up the phone)
            dr = comm.ExecuteReader();  // Fill the DataReader
            
            while (dr.Read())
            {
                // Change the Admin level to whatever the Employee's level is...else remains zero
                intAdminLevel = Convert.ToInt16(dr["MyLevel"].ToString());
            }

            conn.Close();               // Close the connection (hangs up phone)

            // Return the person's Admin Level
            return intAdminLevel;
        }
    }
}
