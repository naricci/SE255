using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class MyUtilities
    {
        public static SqlDataReader GetMyStates()
        {
            //Create my DB objects 
            SqlConnection conn = new SqlConnection();
            SqlCommand comm = new SqlCommand();

            //Create my strings to interact with DB objects 
            string strConn = @GetConnected(); 
            string strSQL = "SELECT State FROM States";

            //Initialize DB objects 
            conn.ConnectionString = strConn;
            comm.Connection = conn;
            comm.CommandText = strSQL;

            //SqlDataReader dr = comm.ExecuteReader(); 
            //ComboBox cmb = new ComboBox(); 
            //while (cir.Read()) 
            //{ 
            //  cmb. Items. Add (dr ["state"] . ToString ()); 
            //} 

            //return cmb; 

            //open connection to DB 
            conn.Open();
            //conn.Close(); 
            //Fill a DataReader and return it return comm.ExecuteReader();

            return comm.ExecuteReader();
        }


        public static string GetConnected()
        {
            return "SQL.NEIT.EDU,4500;Database=SE255_NRicci;User Id = SE255_NRicci;Password=001405200;";
        }
    };
}