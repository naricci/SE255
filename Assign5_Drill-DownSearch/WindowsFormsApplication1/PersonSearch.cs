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
    public partial class PersonSearch : Form
    {
        public PersonSearch()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        { 
            // Get Data
            Person temp = new Person();
            // Perform the search we created in Person class and store the returned dataset
            DataSet ds = temp.SearchContacts(txtFirstName.Text, txtLastName.Text);

            // Display data (dataset)
            gvResults.DataSource = ds;                              // point datagrid to dataset
            gvResults.DataMember = ds.Tables["Persons"].ToString(); // What table in the dataset
            // gvResults.DataMember = ds.Tables[0].TableName;       // Alt. Method to display table without knowing the name
        }

        private void btnClearSearch_Click(object sender, EventArgs e)
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

            // Reset EmployeeID Checkbox
            chkEmployee.Checked = false;
        }

        private void gvResults_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Gather the information (Gathers the row clicked, hen chooses the first cell's data
            string strPerson_ID = gvResults.Rows[e.RowIndex].Cells[0].Value.ToString();

            // Display data in Pop-up
            //MessageBox.Show("Person ID: " + strPerson_ID);

            // Convert the string over to an integer
            int intPerson_ID = Convert.ToInt32(strPerson_ID);

            /** 
             * Create the editor form, passing it one person's ID and show it
             * NOTE THAT THE ID BEING PASSED WILL CALL THE OVERLOADED VERSION
             * OF THE CONSTRUCTO...TELL IT, IN ESSENCE THAT WE ARE PULLING UP
             * RATHER THAN ADDING DATA
             */
            Form1 Editor = new Form1(intPerson_ID);
            Editor.ShowDialog();
        }

        private void chkEmployee_CheckedChanged(object sender, EventArgs e)
        {
            // Show EmployeeID Label + Textbox
            //lblEmployeeID.Enabled = true;
            //lblEmployeeID.Visible = true;
            //txtEmployeeID.Enabled = true;
            //txtEmployeeID.Visible = true;

        }
    }
}
