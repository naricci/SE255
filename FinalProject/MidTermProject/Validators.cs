using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidTermProject
{
    class Validators
    {
        //**********************************************************************************************
        // Library of validation functions we can use in future projects
        //**********************************************************************************************

        // Receives a string and we can let user know if it is filled in
        public static bool IsItFilledIn(string temp)
        {
            bool result = false;

            if (temp.Length > 0)
            {
                result = true;
            }

            return result;
        }


        // Receives a string and we can let user know if it is filled in
        public static bool IsItFilledIn(string temp, int minlen)
        {
            bool result = false;

            if (temp.Length >= minlen)
            {
                result = true;
            }

            return result;
        }


        // Receives a string and we can let user know if it has a semi-valid email format
        /*
        public static bool IsValidEmail(string strEmail)
        {
            // assume true, but look for bad stuff to make it false
            bool result = true;

            // Look for position of "@"
            int atLocation = strEmail.IndexOf("@");
            int NextatLocation = strEmail.IndexOf("@", atLocation + 1);

            // Look for position of last period "."
            int periodLocation = strEmail.LastIndexOf(".");

            // check for minimum length
            if (strEmail.Length < 8)
            {
                result = false;
            }
            else if (atLocation < 2)    // if it is -1, not found and needs at least 2 chars in front
            {
                result = false;
            }
            else if (periodLocation + 2 > (strEmail.Length))
            {
                result = false;
            }

            return result;
        } */


        // Receives a string and we can let user know if it has a valid email format
        public static bool IsValidEmail(string strEmail)
        {
            bool result = false;

            if (strEmail.Contains('@') && strEmail.Contains('.'))
            {
                string[] seperate = strEmail.Split('@', '.');

                string strUname = seperate[0];
                string strDomain = seperate[1];
                string strSuffix = seperate[2];

                if (strUname.Length > 3 & strDomain.Length > 1 & strSuffix.Length > 1)
                {
                    result = true;
                }
            }

            return result;
        }


        // Receives a string and lets user know if State abbreviation is proper length (2).
        public static bool IsValidLength(string strTemp, int intLength)
        {
            bool result = false;

            // Check for correct length of characters
            if (strTemp.Length != intLength)
            {
                result = false;
            }
            else
            {
                result = true;
            }

            return result;
        }


        // Receives an integer and lets user know if State abbreviation is proper length (2).
        public static bool IsValidLength(int intTemp, int intLength)
        {
            bool result = false;

            // Check for correct length of characters
            if (intTemp != intLength)
            {
                result = false;
            }
            else
            {
                result = true;
            }

            return result;
        }


        // Receives a string and we can let user know if length of Country name is a valid length.
        public static bool IsWithinRange(string strTemp, int intMinLen, int intMaxLen)
        {
            bool result = false;

            if (strTemp.Length >= intMinLen && strTemp.Length <= intMaxLen)
            {
                result = true;
            }

            return result;
        }


        // Receives a string and checks if the string is all numbers
        public static bool IsNumber(string strTemp)
        {
            bool result = strTemp.All(char.IsDigit);
            return result;
        }


        // Receives an and checks if the number is positive
        public static bool IsPositiveNumber(int intTemp)
        {
            bool result = false;

            if (intTemp <= 0)
            {
                result = false;
            }

            return result;
        }

        // Receives an integer and checks if the number is greater than or equal to another integer
        public static bool IsAtLeastThisMany(int intTemp, int intMin)
        {
            bool result = true;

            if (intTemp < intMin)
            {
                result = false;
            }

            return result;
        }

        // Check to make sure all characters are digits
        public static bool IsAllDigits(string temp)
        {
            bool result = true;

            foreach (Char c in temp)
            {
                if (Char.IsDigit(c) == false)
                {
                    result = false;
                }
            }

            return result;
        }

        // Receives a string and checks to make sure number is valid jersey number
        public static bool IsValidJerseyNumber(string strTemp)
        {
            bool result = true;

            foreach (Char c in strTemp)
            {
                if (Char.IsDigit(c) == false)
                {
                    result = false;
                }
            }

            if (Convert.ToInt16(strTemp) < 1)
            {
                result = false;
            }
            else if (Convert.ToInt16(strTemp) > 99)
            {
                result = false;
            }
           
            return result;
        }

        // Receives a string from combobox and checks that it's not null/unselected
        public static bool SelectionChecker(string strTemp)
        {
            bool result = false;

            if (strTemp.Contains("Pick"))
            {
                result = true;
            }

            return result;
        }

        // DateTime Validator checks to make sure d1 is before d2
        public static bool Compare(DateTime d1, DateTime d2)
        {
            bool result = (d1 < d2);
            return result;
        }
    };
}
