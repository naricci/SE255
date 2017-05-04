using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Lab 4 System Libraries to include
using System.Data;                  // Library to bring in a dataset
using System.Data.SqlClient;        // Library to connect to SQL Server

namespace WindowsFormsApplication1
{
    public class Employee : Person
    {
        // Set private variables within Employee class
        private string employeeID;
        private double hourlyRate;
        private string feedback;

        // Create public variables to use as the front-end for their private counterparts above
        public string EmployeeID
        {
            get { return employeeID; }
            set
            {
                if (ValidationLibrary.IsItFilledIn(value) == false)
                {
                    feedback += "ERROR: Please fill in a proper numeric value for Employee ID.\n";
                }
                else
                {
                    employeeID = value;
                }
            }
        }

        public double HourlyRate
        {
            get { return hourlyRate; }
            set
            {
                if (double.IsNaN(hourlyRate) == true)
                {
                    feedback += "ERROR: You screwed up.\n";
                }
                /*
                if (ValidationLibrary.IsItFilledIn(value) == false)
                {
                    feedback += "ERROR: Please fill in a positive numeric value for Hourly Rate.\n";
                }
                else if (ValidationLibrary.IsPositiveNumber(value) == true)
                {
                    feedback += "ERROR: Invalid Rate:  Please enter a positive number!\n";
                }
                else if (hourlyRate < 10)
                {
                    feedback += "ERROR: Employee must make at least $10 an hour (minimum wage).\n";
                }
                */
                else
                { 
                    hourlyRate = value;
                }
            }
        }


        // Employee Constructor
        public Employee():base()
        {
            // initialize employee hourly rate to minimum wage
            hourlyRate = 10;
            
            // Start by giving the feedback an empty string
            feedback = "";
        }

        // Overloaded Constructor
        public Employee(string fName, string mName, string lName, string street1, string street2, string city, string state, string zipcode, string country, string phone, string email, string employeeID, double hourlyRate):base()
        {
            // initialize employee hourly rate to minimum wage
            hourlyRate = 10;
            
            // Start by giving the feedback an empty string
            feedback = "";
        }


        // Function to add Employee to Persons DB
        public string AddEmployee()
        {
            string strFeedback = "";    // User feedback

            string strConn = "Server=SQL.NEIT.EDU,4500;Database=SE255_NRicci;User Id=SE255_NRicci;Password = 001405200;";   // Connection String

            SqlConnection conn = new SqlConnection();   // Create a Connection Object
            conn.ConnectionString = strConn;    // Point the Connection Object to our Connection String

            SqlCommand comm = new SqlCommand(); // Create a Command Object
            // Needs to know the connection and sql string
            comm.Connection = conn;
            comm.CommandText = "INSERT INTO Employees (FName, MName, LName, Street1, Street2, City, State, Zipcode, Country, Phone, Email, EmployeeID, HourlyRate) VALUES (@FName, @MName, @LName, @Street1, @Street2, @City, @State, @Zipcode, @Country, @Phone, @Email, @EmployeeID, @HourlyRate)";

            comm.Parameters.AddWithValue("@FName", FName);
            comm.Parameters.AddWithValue("@MName", MName);
            comm.Parameters.AddWithValue("@LName", LName);
            comm.Parameters.AddWithValue("@Street1", Street1);
            comm.Parameters.AddWithValue("@Street2", Street2);
            comm.Parameters.AddWithValue("@City", City);
            comm.Parameters.AddWithValue("@State", State);
            comm.Parameters.AddWithValue("@Zipcode", Zipcode);
            comm.Parameters.AddWithValue("@Country", Country);
            comm.Parameters.AddWithValue("@Phone", Phone);
            comm.Parameters.AddWithValue("@Email", Email);
            comm.Parameters.AddWithValue("@EmployeeID", EmployeeID);
            comm.Parameters.AddWithValue("@HourlyRate", HourlyRate);

            // Try Catch Block for DB
            try
            {
                conn.Open();

                // Perform our add
                strFeedback = comm.ExecuteNonQuery().ToString() + " Record(s) Added";

                conn.Close();

                // got here...we must be fine
                // strFeedback = "All good here";   // Main job is to add now, not just connect...
            }
            catch (Exception err)
            {
                strFeedback = "ERROR: " + err.Message;
            }

            return strFeedback;     // Return User feedback
        }


        // Function that adds Person to DB
        public string AddPerson()
        {
            string strFeedback = "";    // User feedback

            string strConn = "Server=SQL.NEIT.EDU,4500;Database=SE255_NRicci;User Id=SE255_NRicci;Password = 001405200;";   // Connection String

            SqlConnection conn = new SqlConnection();   // Create a Connection Object
            conn.ConnectionString = strConn;    // Point the Connection Object to our Connection String

            SqlCommand comm = new SqlCommand(); // Create a Command Object
            // Needs to know the connection and sql string
            comm.Connection = conn;
            comm.CommandText = "INSERT INTO Persons (FName, MName, LName, Street1, Street2, City, State, Zipcode, Country, Phone, Email) VALUES (@FName, @MName, @LName, @Street1, @Street2, @City, @State, @Zipcode, @Country, @Phone, @Email)";

            comm.Parameters.AddWithValue("@FName", FName);
            comm.Parameters.AddWithValue("@MName", MName);
            comm.Parameters.AddWithValue("@LName", LName);
            comm.Parameters.AddWithValue("@Street1", Street1);
            comm.Parameters.AddWithValue("@Street2", Street2);
            comm.Parameters.AddWithValue("@City", City);
            comm.Parameters.AddWithValue("@State", State);
            comm.Parameters.AddWithValue("@Zipcode", Zipcode);
            comm.Parameters.AddWithValue("@Country", Country);
            comm.Parameters.AddWithValue("@Phone", Phone);
            comm.Parameters.AddWithValue("@Email", Email);

            try
            {
                conn.Open();

                // Perform our add
                strFeedback = comm.ExecuteNonQuery().ToString() + " Record(s) Added";

                conn.Close();

                // got here...we must be fine
                // strFeedback = "All good here";   // Main job is to add now, not just connect...
            }
            catch (Exception err)
            {
                strFeedback = "ERROR: " + err.Message;
            }

            return strFeedback;     // Return User feedback
        }


        // Function that searchs for a Person, or Persons, in DB
        public DataSet SearchContacts(String FName, String LName)
        {
            //Create a dataset to return filled
            DataSet ds = new DataSet();

            //Create a command for our SQL statement
            SqlCommand comm = new SqlCommand();

            //Write a Select Statement to perform Search
            String strSQL = "SELECT Person_ID, FName, MName, LName FROM Employees WHERE 0=0";

            //If the First/Last Name is filled in include it as search criteria
            if (FName.Length > 0)
            {
                strSQL += " AND FName LIKE @FName";
                comm.Parameters.AddWithValue("@FName", "%" + FName + "%");
            }
            if (MName.Length > 0)
            {
                strSQL += " AND MName LIKE @MName";
                comm.Parameters.AddWithValue("@MName", "%" + MName + "%");
            }
            if (LName.Length > 0)
            {
                strSQL += " AND LName LIKE @LName";
                comm.Parameters.AddWithValue("@LName", "%" + LName + "%");
            }

            //Create DB tools and Configure
            //*********************************************************************************************
            SqlConnection conn = new SqlConnection();
            //Create the who, what where of the DB
            string strConn = @"Server=SQL.NEIT.EDU,4500;Database=SE255_NRicci;User Id=SE255_NRicci;Password = 001405200;";   // Connection String
            conn.ConnectionString = strConn;

            //Fill in basic info to command object
            comm.Connection = conn;     //tell the commander what connection to use
            comm.CommandText = strSQL;  //tell the command what to say

            //Create Data Adapter
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = comm;    //commander needs a translator(dataAdapter) to speak with datasets

            //*********************************************************************************************

            //Get Data
            conn.Open();                //Open the connection (pick up the phone)
            da.Fill(ds, "Employees");     //Fill the dataset with results from database and call it "Persons"
            conn.Close();               //Close the connection (hangs up phone)

            //Return the data
            return ds;
        }


        //Method that returns a Data Reader filled with all the data
        // of one person.  This one person is specified by the ID passed
        // to this function
        public SqlDataReader FindOnePerson(int intPerson_ID)
        {
            //Create and Initialize the DB Tools we need
            SqlConnection conn = new SqlConnection();
            SqlCommand comm = new SqlCommand();

            //My Connection String
            string strConn = @"Server=SQL.NEIT.EDU,4500;Database=SE255_NRicci;User Id=SE255_NRicci;Password = 001405200;";  // Connection string

            //My SQL command string to pull up one person's data
            string sqlString = "SELECT Person_ID, FName, MName, LName FROM Employees WHERE Person_ID = @Person_ID;";

            //Tell the connection object the who, what, where, how
            conn.ConnectionString = strConn;

            //Give the command object info it needs
            comm.Connection = conn;
            comm.CommandText = sqlString;
            comm.Parameters.AddWithValue("@Person_ID", intPerson_ID);

            //Open the DataBase Connection and Yell our SQL Command
            conn.Open();

            //Return some form of feedback
            return comm.ExecuteReader();   //Return the dataset to be used by others (the calling form)

        }
    };
}
