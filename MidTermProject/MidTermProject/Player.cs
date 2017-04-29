using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;                 
using System.Data.SqlClient;


namespace MidTermProject
{
    // Create class to represent Person object
    public class Player
    {
        // Set private variables within Person class
        private string firstName;
        private string lastName;
        private int age;
        private DateTime birthday;
        private int jerseyNum;
        private string position;
        private string shot;
        private int goals;
        private int assists;
        private string notes;
        private string feedback;

        // Create public variables to use as the front-end for their private counterparts above
        public string FirstName
        {
            get { return firstName; }
            set
            {
                if (Validators.IsItFilledIn(value, 1) == false)
                {
                    feedback += "ERROR: Invalid First Name...Must be at least 1 character.\n";
                }
                else
                {
                    firstName = value;
                }
            }
        }

        public string LastName
        {
            get { return lastName; }
            set
            {
                if (Validators.IsItFilledIn(value, 1) == false)
                {
                    feedback += "ERROR: Invalid Last Name...Must be at least 1 character.\n";
                }
                else
                {
                    lastName = value;
                }
            }
        }

        public int Age
        {
            get { return age; }
            set
            {
                if (Validators.IsAllDigits(value.ToString()) == false)
                {
                    feedback += "ERROR: Please fill in the player's appropriate age.\n";
                }
                else if (Validators.IsAtLeastThisMany(value, 18) == false)
                {
                    feedback += "ERROR: Invalid age...Must be at least 18 years old.\n";
                }
                else
                {
                    age = value;
                }           
            }
        }

        public DateTime Birthday
        {
            get { return birthday; }
            set
            {
                birthday = value;
            }
        }

        public int JerseyNum
        {
            get { return jerseyNum; }
            set
            {
                if (Validators.IsItFilledIn(value.ToString(), 1) == false)
                {
                    feedback += "ERROR: Please enter the player's jersey number.\n";
                }
                if (Validators.IsValidJerseyNumber(value.ToString()) == false)
                {
                    feedback += "ERROR: Please enter a jersey number between 1 and 99.\n";
                }
                else
                {
                    jerseyNum = value;
                }
            }
        }

        public string Position
        {
            get { return position; }
            set
            {
                if (Validators.SelectionChecker(value) == true)
                {
                    feedback += "ERROR: Please choose a position.\n";
                }
                else
                {
                    position = value;
                }
            }
        }

        public string Shot
        {
            get { return shot; }
            set
            {
                if (Validators.SelectionChecker(value) == true)
                {
                    feedback += "ERROR: Please choose a shot type.\n";
                }
                else
                { 
                    shot = value;
                }
            }
        }

        public int Goals
        {
            get { return goals; }
            set
            {
                if (Validators.IsItFilledIn(value.ToString(), 1) == false)
                {
                    feedback += "ERROR: Please fill in number of goals the player has scored.\n";
                }
                else if (Validators.IsPositiveNumber(value) == true)
                {
                    feedback += "ERROR: Cannot enter a number lower than 0.\n";
                }
                else
                {
                    goals = value;
                }
            }
        }

        public int Assists
        {
            get { return assists; }
            set
            {
                if (Validators.IsItFilledIn(value.ToString(), 1) == false)
                {
                    feedback += "ERROR: Please fill in number of assists the player has scored.\n";
                }
                else if (Validators.IsPositiveNumber(value) == true)
                {
                    feedback += "ERROR: Cannot enter a number lower than 0.\n";
                }
                else
                {
                    assists = value;
                }
            }
        }

        public string Notes
        {
            get { return notes; }
            set { notes = value; }
        }

        public string Feedback
        {
            get { return feedback; }
        }

        // Default Constructor
        public Player()
        {
            feedback = "";
        }

        // Overloaded Constructor
        public Player(string firstName, string lastName, int age, DateTime birthday, int jerseyNum, string position, string shot, int goals, int assists, string notes)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.Birthday = birthday;
            this.JerseyNum = jerseyNum;
            this.Position = position;
            this.Shot = shot;
            this.Goals = goals;
            this.Assists = assists;
            this.Notes = notes;

            feedback = "";
        }


        // Function to ADD player to BostonBruins DB
        public string AddPlayer()
        {
            string strFeedback = "";    // User feedback

            string strConn = "Server=SQL.NEIT.EDU,4500;Database=SE255_NRicci;User Id=SE255_NRicci;Password = 001405200;";   // Connection String

            SqlConnection conn = new SqlConnection();   // Create a Connection Object
            conn.ConnectionString = strConn;    // Point the Connection Object to our Connection String

            SqlCommand comm = new SqlCommand(); // Create a Command Object
            // Needs to know the connection and sql string
            comm.Connection = conn;
            comm.CommandText = "INSERT INTO BostonBruins (FirstName, LastName, Age, Birthday, JerseyNum, Position, Shot, Goals, Assists, Notes) VALUES (@FirstName, @LastName, @Age, @Birthday, @JerseyNum, @Position, @Shot, @Goals, @Assists, @Notes)";

            comm.Parameters.AddWithValue("@FirstName", FirstName);
            comm.Parameters.AddWithValue("@LastName", LastName);
            comm.Parameters.AddWithValue("@Age", Age);
            comm.Parameters.AddWithValue("@Birthday", Birthday);
            comm.Parameters.AddWithValue("@JerseyNum", JerseyNum);
            comm.Parameters.AddWithValue("@Position", Position);
            comm.Parameters.AddWithValue("@Shot", Shot);
            comm.Parameters.AddWithValue("@Goals", Goals);
            comm.Parameters.AddWithValue("@Assists", Assists);
            comm.Parameters.AddWithValue("@Notes", Notes);

            try
            {
                conn.Open();

                // Perform our add
                strFeedback = comm.ExecuteNonQuery().ToString() + " Player(s) Added";

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
