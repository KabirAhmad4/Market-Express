using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CRUDA.Classes
{
    public  class Validation
    {

        public Validation() { }

       public bool IsValidEmail(string eMail)
        {
            bool Result = true;

            try
            {
                Regex emailRegex = new Regex(@"^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}$");

                // Check if the email matches the regular expression
                Result = emailRegex.IsMatch(eMail);

            }
            catch
            {
                Result = false;
            };

            return Result;
        }
        public bool IsValidPhoneNumber(string phoneNumber)
        {
            // regular expression pattern for a valid phone number
            string pattern = @"^\+\d{1,3}\d{3,}$";

            Regex regex = new Regex(pattern);

            return regex.IsMatch(phoneNumber);
        }


    }



}
