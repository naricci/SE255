using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;                  // Library to bring in a dataset
using System.Data.SqlClient;        // Library to connect to SQL Server

namespace WindowsFormsApplication1
{
    // Create class to represent Person object
    public class Person
    {
        // Set private variables within Person class
        private string fName;
        private string mName;
        private string lName;
        private string street1;
        private string street2;
        private string city;
        private string state;
        private string zipcode;
        private string country;
        private string phone;
        private string email;
        private string feedback;

        // Create public variables to use as the front-end for their private counterparts above
        public string FName
        {
            get { return fName; }
            set
            {
                if (ValidationLibrary.IsItFilledIn(value, 1) == false)
                {
                    feedback += "ERROR: Invalid First Name...Must be at least 1 character.\n";
                }
                else
                {
                    fName = value;
                }
            }
        }

        public string MName
        {
            get { return mName; }
            set
            {
                mName = value;
            }
        }

        public string LName
        {
            get { return lName; }
            set
            {
                if (ValidationLibrary.IsItFilledIn(value, 1) == false)
                {
                    feedback += "ERROR: Invalid Last Name...Must be at least 1 character.\n";
                }
                else
                {
                    lName = value;
                }
            }
        }

        public string Street1
        {
            get { return street1; }
            set
            {
                street1 = value;
            }
        }

        public string Street2
        {
            get { return street2; }
            set
            {
                street2 = value;
            }
        }

        public string City
        {
            get { return city; }
            set
            {
                city = value;
            }
        }

        public string State
        {
            get { return state; }
            set
            {
                if (ValidationLibrary.IsValidLength(value, 2) == false)
                {
                    feedback += "ERROR: Invalid length for State abbreviation...Must be exactly 2 letters.\n";
                }
                else
                {
                    state = value;
                }
            }
        }

        public string Zipcode
        {
            get { return zipcode; }
            set
            {
                if (ValidationLibrary.IsValidLength(value, 5) == false)
                {
                    feedback += "ERROR: Invalid length for Zip Code...Must be exactly five numbers.\n";
                }
                else if (ValidationLibrary.IsNumber(value) == false)
                {
                    feedback += "ERROR: Zip Code must be a 5-digit number.\n";
                }
                else
                {
                    zipcode = value;
                }
            }
        }

        public string Country
        {
            get { return country; }
            set
            {
                if (ValidationLibrary.IsWithinRange(value, 3, 20) == false)
                {
                    feedback += "ERROR: Invalid length for Country name...Must be between 3 and 20 characters.\n";
                }
                else
                {
                    country = value;
                }
            }
        }

        public string Phone
        {
            get { return phone; }
            set
            {
                phone = value;
            }
        }

        public string Email
        {
            get { return email; }
            set
            {
                if (ValidationLibrary.IsValidEmail(value) == false)
                {
                    feedback += "ERROR: Invalid Email Address format...\n";
                }
                else
                {
                    email = value;
                }
            }
        }

        public string Feedback
        {
            get { return feedback; }
        }


        // Default Constructor
        public Person()
        {
            feedback = "";
        }

        // Overloaded Constructor
        public Person(string fName, string mName, string lName, string street1, string street2, string city, string state, string zipcode, string country, string phone, string email)
        {
            this.FName = fName;
            this.MName = mName;
            this.LName = lName;
            this.Street1 = street1;
            this.Street2 = street2;
            this.City = city;
            this.State = state;
            this.Zipcode = zipcode;
            this.Country = country;
            this.Phone = phone;
            this.Email = email;

            // Start by giving the feedback an empty string
            feedback = "";
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

            try { 
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
            // Create a dataset to return filled
            DataSet ds = new DataSet();

            // Create a command for our SQL statement
            SqlCommand comm = new SqlCommand();

            // Write a Select Statement to perform Search
            String strSQL = "SELECT Person_ID, FName, LName FROM Persons WHERE 0=0";

            // If the First/Last Name is filled in include it as search criteria
            if (FName.Length > 0)
            {
                strSQL += " AND FName LIKE @FName";
                comm.Parameters.AddWithValue("@FName", "%" + FName + "%");
            }
            if (LName.Length > 0)
            {
                strSQL += " AND LName LIKE @LName";
                comm.Parameters.AddWithValue("@LName", "%" + LName + "%");
            }

            // Create DB tools and Configure
            //*********************************************************************************************
            SqlConnection conn = new SqlConnection();
            // Create the who, what where of the DB
            string strConn = @"Server=SQL.NEIT.EDU,4500;Database=SE255_NRicci;User Id=SE255_NRicci;Password = 001405200;";   // Connection String
            conn.ConnectionString = strConn;

            // Fill in basic info to command object
            comm.Connection = conn;     // tell the commander what connection to use
            comm.CommandText = strSQL;  // tell the command what to say

            // Create Data Adapter
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = comm;    // commander needs a translator(dataAdapter) to speak with datasets

            //*********************************************************************************************

            // Get Data
            conn.Open();                // Open the connection (pick up the phone)
            da.Fill(ds, "Persons");     // Fill the dataset with results from database and call it "Persons"
            conn.Close();               // Close the connection (hangs up phone)

            // Return the data
            return ds;
        }


        // Method that returns a Data Reader filled with all the data
        // of one person.  This one person is specified by the ID passed
        // to this function
        public SqlDataReader FindOnePerson(int intPerson_ID)
        {
            // Create and Initialize the DB Tools we need
            SqlConnection conn = new SqlConnection();
            SqlCommand comm = new SqlCommand();

            // My Connection String
            string strConn = @"Server=SQL.NEIT.EDU,4500;Database=SE255_NRicci;User Id=SE255_NRicci;Password = 001405200;";  // Connection string

            // My SQL command string to pull up one person's data
            string sqlString =
            "SELECT Person_ID, FName, MName, LName, Street1, Street2, City, State, ZipCode, Country, Phone, Email FROM Persons WHERE Person_ID = @Person_ID;";

            // Tell the connection object the who, what, where, how
            conn.ConnectionString = strConn;

            // Give the command object info it needs
            comm.Connection = conn;
            comm.CommandText = sqlString;
            comm.Parameters.AddWithValue("@Person_ID", intPerson_ID);

            // Open the DataBase Connection and Yell our SQL Command
            conn.Open();

            // Return some form of feedback
            return comm.ExecuteReader();   // Return the dataset to be used by others (the calling form)

        }
    };
}
