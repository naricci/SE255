using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        private string phone;
        private string email;

        // Create public variables to use as the front-end for their private counterparts above
        public string FName
        {
            // Accessor
            get { return fName; }       // Returns a copy of the value stored in the private variable to the outside world
            // Mutator
            set                         // Allows the private variable to get the value of the public variable if it
            {
                fName = value;
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
                lName = value;
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
                state = value;
            }
        }

        public string Zipcode
        {
            get { return zipcode; }
            set
            {
                zipcode = value;
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
                email = value;
            }
        }
    }
};
