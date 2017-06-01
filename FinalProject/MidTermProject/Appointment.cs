using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidTermProject
{
    class Appointment
    {
        private DateTime startdate;
        private DateTime enddate;
        private string firstname;
        private string lastname;
        private string location;
        private string comments;
        private string feedback;
        public int Appointment_ID = 0;

        public DateTime StartDate
        {
            get { return startdate; }
            set
            {
                startdate = value;
            }
        }

        public DateTime EndDate
        {
            get { return enddate; }
            set
            {
                if (Validators.Compare(startdate, value) == false)
                {
                    feedback += "ERROR: Start Date cannot be after End Date.\n";
                }
                else
                {
                    enddate = value;
                }
            }
        }

        public string FirstName
        {
            get { return firstname; }
            set
            {
                if (Validators.IsItFilledIn(value, 1) == false)
                {
                    feedback += "ERROR: Invalid First Name...Must be at least 1 character.\n";
                }
                else
                {
                    firstname = value;
                }
            }
        }

        public string LastName
        {
            get { return lastname; }
            set
            {
                if (Validators.IsItFilledIn(value, 1) == false)
                {
                    feedback += "ERROR: Invalid Last Name...Must be at least 1 character.\n";
                }
                else
                {
                    lastname = value;
                }
            }
        }

        public string Location
        {
            get { return location; }
            set
            {
                if (Validators.IsItFilledIn(value, 1) == false)
                {
                    feedback += "ERROR: Invalid Location...Please enter a location.\n";
                }
                else
                {
                    location = value;
                }
            }
        }

        public string Comments
        {
            get { return comments; }
            set { comments = value; }
        }

        public string Feedback
        {
            get { return feedback; }
            set { feedback = value; }
        }

        public Appointment()
        {
            feedback = "";
        }

        public void FillLabel()
        {

        }

        // Function that adds Person to DB
        public string AddAppointment()
        {
            string strFeedback = "";    // User feedback

            string strConn = "Server=SQL.NEIT.EDU,4500;Database=SE255_NRicci;User Id=SE255_NRicci;Password = 001405200;";   // Connection String

            SqlConnection conn = new SqlConnection();   // Create a Connection Object
            conn.ConnectionString = strConn;    // Point the Connection Object to our Connection String

            SqlCommand comm = new SqlCommand(); // Create a Command Object
            // Needs to know the connection and sql string
            comm.Connection = conn;
            comm.CommandText = "INSERT INTO Appointments (StartDate, EndDate, FirstName, LastName, Location, Comments) VALUES (@StartDate, @EndDate, @FirstName, @LastName, @Location, @Comments)";

            comm.Parameters.AddWithValue("@StartDate", StartDate);
            comm.Parameters.AddWithValue("@EndDate", EndDate);
            comm.Parameters.AddWithValue("@FirstName", FirstName);
            comm.Parameters.AddWithValue("@LastName", LastName);
            comm.Parameters.AddWithValue("@Location", Location);
            comm.Parameters.AddWithValue("@Comments", Comments);

            try
            {
                conn.Open();

                // Perform our add
                strFeedback = comm.ExecuteNonQuery().ToString() + " Appointment(s) Added";

                conn.Close();
            }
            catch (Exception err)
            {
                strFeedback = "ERROR: " + err.Message;
            }

            return strFeedback;     // Return User feedback
        }



        // Function that searchs for a Person, or Persons, in DB
        public DataSet SearchAppointments(String FirstName, String LastName, String Location)
        {
            // Create a dataset to return filled
            DataSet ds = new DataSet();

            // Create a command for our SQL statement
            SqlCommand comm = new SqlCommand();

            // Write a Select Statement to perform Search
            String strSQL = "SELECT Appointment_ID, FirstName, LastName, Location FROM Appointments WHERE 0=0";

            // If the First/Last Name is filled in include it as search criteria
            if (FirstName.Length > 0)
            {
                strSQL += " AND FirstName LIKE @FirstName";
                comm.Parameters.AddWithValue("@FirstName", "%" + FirstName + "%");
            }
            if (LastName.Length > 0)
            {
                strSQL += " AND LastName LIKE @LastName";
                comm.Parameters.AddWithValue("@LastName", "%" + LastName + "%");
            }
            if (Location.Length > 0)
            {
                strSQL += " AND Location LIKE @Location";
                comm.Parameters.AddWithValue("@Location", "%" + Location + "%");
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
            da.Fill(ds, "Appointments");     // Fill the dataset with results from database and call it "Appointments"
            conn.Close();               // Close the connection (hangs up phone)

            // Return the data
            return ds;
        }



        // Method that returns a Data Reader filled with all the data
        // of one person.  This one person is specified by the ID passed
        // to this function
        public SqlDataReader FindOneAppointment(int intAppointment_ID)
        {
            // Create and Initialize the DB Tools we need
            SqlConnection conn = new SqlConnection();
            SqlCommand comm = new SqlCommand();

            // My Connection String
            string strConn = @"Server=SQL.NEIT.EDU,4500;Database=SE255_NRicci;User Id=SE255_NRicci;Password = 001405200;";  // Connection string

            // My SQL command string to pull up one person's data
            string sqlString =
            "SELECT Appointment_ID, StartDate, EndDate, FirstName, LastName, Location, Comments FROM Appointments WHERE Appointment_ID = @Appointment_ID;";

            // Tell the connection object the who, what, where, how
            conn.ConnectionString = strConn;

            // Give the command object info it needs
            comm.Connection = conn;
            comm.CommandText = sqlString;
            comm.Parameters.AddWithValue("@Appointment_ID", intAppointment_ID);

            // Open the DataBase Connection and Yell our SQL Command
            conn.Open();

            // Return some form of feedback
            return comm.ExecuteReader();   // Return the dataset to be used by others (the calling form)
        }



        //Method that will delete one person record specified by the ID
        //It will return an Interger meant for feedback on how many 
        // records were deleted
        public Int32 DeleteOneAppointment(int intAppointment_ID)
        {
            Int32 intRecords = 0;

            //Create and Initialize the DB Tools we need
            SqlConnection conn = new SqlConnection();
            SqlCommand comm = new SqlCommand();

            //My Connection String
            string strConn = @"Server=SQL.NEIT.EDU,4500;Database=SE255_NRicci;User Id=SE255_NRicci;Password = 001405200;";

            //My SQL command string to pull up one person's data
            string sqlString =
           "DELETE FROM Appointments WHERE Appointment_ID = @Appointment_ID;";

            //Tell the connection object the who, what, where, how
            conn.ConnectionString = strConn;

            //Give the command object info it needs
            comm.Connection = conn;
            comm.CommandText = sqlString;
            comm.Parameters.AddWithValue("@Appointment_ID", intAppointment_ID);

            //Open the DataBase Connection and Yell our SQL Command
            conn.Open();

            //Run the deletion and store the number of records effected
            intRecords = comm.ExecuteNonQuery();

            //close the connection
            conn.Close();

            return intRecords;   //Return # of records deleted
        }



        public Int32 UpdateAnAppointment()
        {
            Int32 intRecords = 0;

            //Create SQL command string
            string strSQL = "UPDATE Appointments SET StartDate = @StartDate, EndDate = @EndDate, FirstName = @FirstName, LastName = @LastName, Location = @Location, Comments = @Comments WHERE Appointment_ID = @Appointment_ID;";

            // Create a connection to DB
            SqlConnection conn = new SqlConnection();

            //Create the who, what where of the DB
            string strConn = @"Server=SQL.NEIT.EDU,4500;Database=SE255_NRicci;User Id=SE255_NRicci;Password = 001405200;";
            conn.ConnectionString = strConn;

            // Bark out our command
            SqlCommand comm = new SqlCommand();
            comm.CommandText = strSQL;  //Commander knows what to say
            comm.Connection = conn;     //Where's the phone?  Here it is

            //Fill in the paramters (Has to be created in same sequence as they are used in SQL Statement)
            comm.Parameters.AddWithValue("@StartDate", StartDate);
            comm.Parameters.AddWithValue("@EndDate", EndDate);
            comm.Parameters.AddWithValue("@FirstName", FirstName);
            comm.Parameters.AddWithValue("@LastName", LastName);
            comm.Parameters.AddWithValue("@Location", Location);
            comm.Parameters.AddWithValue("@Comments", Comments);
            comm.Parameters.AddWithValue("@Appointment_ID", Appointment_ID);

            try
            {
                //Open the connection
                conn.Open();

                //Run the Update and store the number of records effected
                intRecords = comm.ExecuteNonQuery();
            }
            catch (Exception err)
            {
            }
            finally
            {
                //close the connection
                conn.Close();
            }

            return intRecords;
        }
    }
}
