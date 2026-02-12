using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace LibrarySYS
{
    /// <summary>
    ///     Provides validation logic for member-related data within the Library System.
    ///     This class is responsible for validating individual member fields such as 
    ///     first name, last name, date of birth, phone number, email, and address,
    ///     as well as enforcing business rules such as age restrictions and email format.
    /// </summary>
    public class MemberValidator
    {
        /// <summary>
        /// Determines if the provided first name is valid.
        /// </summary>
        /// <param name="firstName">The first name of the member to be validated.</param>
        /// <returns>
        /// True if the first name is non-empty and does not exceed 30 characters; 
        /// otherwise, false.
        /// </returns>
        public static bool IsValidFirstName(string firstName)
        {
            return !string.IsNullOrWhiteSpace(firstName) && firstName.Length <= 30;
        }

        public static bool IsValidLastName(string lastName)
        {
            return !string.IsNullOrWhiteSpace(lastName) && lastName.Length <= 30;
        }

        public static bool IsValidDOB(DateTime dob)
        {
            DateTime minimumDOB = DateTime.Today.AddYears(-120);
            return dob <= DateTime.Today && dob > minimumDOB;
        }

        public static bool IsValidPhone(string phone)
        {
            if (string.IsNullOrWhiteSpace(phone))
            {
                return false;
            }

            if (phone.Length != 10 && phone.Length != 13)
            {
                return false;
            }

            foreach (char num in phone)
            {
                if (num < '0' || num > '9')
                {
                    return false;
                }
            }

            if (phone.Substring(0, 2) != "08")
            {
                return false;
            }

            return true;
        }

        public static bool IsValidEmail(string email)
        {
            // sample: daniel.courtney@gmail.com
            if (email.Length < 10 || email.Length > 50)
            {
                return false;
            }

            if (!email.Contains("@"))
            {
                return false;
            }

            if (!email.EndsWith(".com") ||
                !email.EndsWith(".org") ||
                !email.EndsWith(".ie") ||
                !email.EndsWith(".net"))
            {
                return false;
            }

            string recipient = email.Substring(0, email.IndexOf("@"));
            string domain = email.Substring(email.IndexOf("@") + 1); 
            
            if (recipient.Length < 1 || recipient.Length > 30) {
                return false;
            }

            if (!IsValidEmailSection(recipient))
            {
                return false;
            }


            if (domain.Length < 2 || domain.Length > 15)
            {
                return false;
            }

            if (!IsValidEmailSection(domain))
            {
                return false;
            }

            return true;
        }

        public static bool IsValidEmailSection(string section)
        {
            foreach (char ch in section)
            {
                if ((ch != '.' && ch != '-' && ch != '_') ||
                    (ch < '0' && ch > '9') ||
                    (ch < 'A' && ch > 'Z') ||
                    (ch < 'a' && ch > 'z'))
                {
                    return false;
                }
            }

            return true;
        }
    }
}
