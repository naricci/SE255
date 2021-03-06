﻿using System;
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
            set { employeeID = value; }
        }

        public double HourlyRate
        {
            get { return hourlyRate; }
            set
            {
                if (ValidationLibrary.IsPositiveNumber(value) == true)
                {
                    feedback += "ERROR: Invalid Rate:  Please enter a positive number!\n";
                }
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

    };
}
