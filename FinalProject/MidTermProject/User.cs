using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidTermProject
{
    class User
    {
        private string uname;
        private string pw;
        private SqlConnection conn;
        private SqlCommand comm;

        public string UName
        {
            get { return uname; }
            set { uname = value; }
        }

        public string PW
        {
            get { return pw; }
            set { pw = value; }
        }

        public SqlDataReader FindOneUser()
        {
            SqlConnection conn = new SqlConnection();
            SqlCommand comm = new SqlCommand();

            string strConn = @MyUtilities.GetConnected(); ;
            string sqlString =
                "SELECT * From Users WHERE UName = @UName AND PW = @PW";
            conn.ConnectionString = strConn;
            comm.Parameters.AddWithValue("@UName", UName);
            comm.Parameters.AddWithValue("PW", PW);

            comm.Connection = conn;
            comm.CommandText = sqlString;

            conn.Open();
            return comm.ExecuteReader();

        }
    }
}
