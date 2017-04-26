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
        
    };
}
