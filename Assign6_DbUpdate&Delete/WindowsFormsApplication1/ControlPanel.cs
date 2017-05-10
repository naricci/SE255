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
    }
}
