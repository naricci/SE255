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

namespace MidTermProject
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool validLogin = false;
            User temp = new User();
            temp.UName = txtUsername.Text;
            temp.PW = txtPassword.Text;
            SqlDataReader dr = temp.FindOneUser();

            while (dr.Read())
            {
                if (temp.UName == dr["UName"].ToString() && temp.PW == dr["PW"].ToString())
                {
                    validLogin = true;
                }
            }

            if (validLogin == false)
            {
                lblFeedback.Text = "ERROR Invalid Credentials...Try again.";
            }
            else
            {
                ControlPanel CM = new ControlPanel();
                CM.ShowDialog();
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '☻';
        }
    }
}
