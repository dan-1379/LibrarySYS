using Oracle.ManagedDataAccess.Client;
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

        /// <summary>
        /// Determines if the provided last name is valid.
        /// </summary>
        /// <param name="lastName">The last name of the member to be validated.</param>
        /// <returns>
        /// True if the last name is non-empty and does not exceed 30 characters; 
        /// otherwise, false.
        /// </returns>
        public static bool IsValidLastName(string lastName)
        {
            return !string.IsNullOrWhiteSpace(lastName) && lastName.Length <= 30;
        }

        /// <summary>
        /// Determines if the provided DOB is valid.
        /// </summary>
        /// <param name="dob">The DOB of the member to be validated.</param>
        /// <returns>
        /// True if the DOB is not a future date and the member is not older than 120 years;
        /// otherwise, false.
        /// </returns>
        public static bool IsValidDOB(DateTime dob)
        {
            DateTime minimumDOB = DateTime.Today.AddYears(-120);
            return dob <= DateTime.Today && dob > minimumDOB;
        }

        /// <summary>
        /// Determines if the provided phone number is valid.
        /// </summary>
        /// <param name="phone">The phone number of the member to be validated.</param>
        /// <returns>
        /// True if the phone number is either 10 or 13 digits long, starts with "08" or "353", and contains only numeric characters;
        /// otherwise, false.
        /// </returns>
        public static string IsValidPhone(string phone)
        {
            int nonDigitCount = 0;

            if (string.IsNullOrWhiteSpace(phone))
            {
                return "A phone number must be entered.";
            }

            if (phone.Length != 10 && phone.Length != 12)
            {
                return "The phone number must have 10 or 13 characters";
            }

            foreach (char num in phone)
            {
                if (num < '0' || num > '9')
                {
                    nonDigitCount++;
                }
            }

            if (nonDigitCount > 0)
            {
                return "The phone number must contain only numeric characters.";
            }

            if (phone.Substring(0, 2) != "08" && phone.Substring(0, 3) != "353")
            {
                return "Phone number must begin with 08 or 353";
            }

            return "valid";
        }

        /// <summary>
        /// Determines if the provided email is valid.
        /// </summary>
        /// <param name="email">The email of the member to be validated.</param>
        /// <returns>
        /// True if the email is between 10 and 50 characters long, contains an "@" symbol, ends with a valid domain, and has valid recipient and domain sections;
        /// </returns>
        public static string IsValidEmail(string email)
        {
            if (email.Length < 10 || email.Length > 40)
            {
                return "Email length must be between 10 and 40.";
            }

            if (!email.Contains("@"))
            {
                return "Email must contain an @ symbol.";
            }

            if (!email.EndsWith(".com") &&
                !email.EndsWith(".org") &&
                !email.EndsWith(".ie") &&
                !email.EndsWith(".net"))
            {
                return "Email must end with a valid domain (.com, .org, .ie, .net).";
            }

            string[] emailSections = email.Split('@');
            string recipient = emailSections[0];

            string[] domainSections = emailSections[1].Split('.');
            string domain = domainSections[0];

            if (recipient.Length < 1 || recipient.Length > 30)
            {
                return "Recipient section of the email must be between 1 and 30 characters.";
            }

            if (!IsValidEmailSection(recipient))
            {
                return "Recipient section must only contain uppercase and lowercase letters, numbers, decimal points, dashes and underscores.";
            }


            if (domain.Length < 2 || domain.Length > 15)
            {
                return "Domain section of the email must be between 2 and 15 characters.";
            }

            if (!IsValidEmailSection(domain))
            {
                return "Domain section must only contain uppercase and lowercase letters, numbers, decimal points, dashes and underscores.";
            }

            return "valid";
        }

        /// <summary>
        /// Helper method for validating the recipient and domain sections of an email address.
        /// </summary>
        /// <param name="section">The section of the email to be validated.</param>
        /// <returns>
        /// True if the section contains only uppercase and lowercase letters, numbers, decimal points, dashes, and underscores;
        /// </returns>
        private static bool IsValidEmailSection(string section)
        {
            foreach (char ch in section)
            {
                if (!Char.IsLetterOrDigit(ch) && ch != '.' && ch != '-' && ch != '_')
                {
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// Determines if the provided address line 1 is valid.
        /// </summary>
        /// <param name="addressLine1">The first line of the address to be validated.</param>
        /// <returns>
        /// True if the address line 1 is non-empty and between 5 and 30 characters long; otherwise, false.
        /// </returns>
        public static bool IsValidAddressLine1(string addressLine1)
        {
            return !string.IsNullOrWhiteSpace(addressLine1) && addressLine1.Length >= 5 && addressLine1.Length <= 30;
        }

        /// <summary>
        /// Determines if the provided address line 2 is valid.
        /// </summary>
        /// <param name="addressLine2">The second line of the address to be validated.</param>
        /// <returns>
        /// True if the address line 2 is either empty or between 5 and 30 characters long; otherwise, false.
        /// </returns>
        public static bool IsValidAddressLine2(string addressLine2)
        {
            return string.IsNullOrWhiteSpace(addressLine2) || (addressLine2.Length >= 5 && addressLine2.Length <= 30);
        }

        /// <summary>
        /// Determines if the provided city is valid.
        /// </summary>
        /// <param name="city">The city of the member to be validated.</param>
        /// <returns>
        /// True if the city is non-empty and between 1 and 30 characters long; otherwise, false.
        /// </returns>
        public static bool IsValidCity(string city)
        {
            return !string.IsNullOrWhiteSpace(city) && city.Length >= 1 && city.Length <= 30;
        }


        /// <summary>
        /// Determines if the provided county is valid.
        /// </summary>
        /// <param name="county">The county of the member to be validated.</param>
        /// <returns>
        /// True if the county is non-empty and between 4 and 30 characters long;
        /// </returns>
        public static bool IsValidCounty(string county)
        {
            return !string.IsNullOrWhiteSpace(county) && county.Length >= 4 && county.Length <= 10;
        }

        /// <summary>
        /// Determines if the provided eircode is valid.
        /// </summary>
        /// <param name="eircode">The eircode of the member to be validated.</param>
        /// <returns>
        /// True if the eircode is 7 characters long, starts with a letter followed by two digits in the 
        /// routing key, and contains only letters and numbers in the unique identifier;
        /// </returns>
        public static string IsValidEircode(string eircode)
        {
            if (string.IsNullOrWhiteSpace(eircode))
            {
                return "An Eircode must be entered.";
            }

            if (eircode.Length != 7)
            {
                return "Eircode must be 7 characters long.";
            }

            string routingKey = eircode.Substring(0, 3);
            string uniqueIdentifier = eircode.Substring(3);
            int nonAlphanumericCount = 0;

            if (!Char.IsLetter(routingKey[0]))
            {
                return "The first character of the routing key must be a letter.";
            }

            if (!Char.IsDigit(routingKey[1]) || !Char.IsDigit(routingKey[2]))
            {
                return "The second and third characters of the routing key must be numbers.";
            }

            foreach (char ch in uniqueIdentifier)
            {
                if (!Char.IsLetterOrDigit(ch))
                {
                    nonAlphanumericCount++;
                }
            }

            if (nonAlphanumericCount > 0)
            {
                return "The unique identifier must contain only letters and numbers.";
            }

            return "valid";
        }

        /// <summary>
        /// Determines if a member with the provided first name, last name, and phone number already exists in the database.
        /// </summary>
        /// <param name="firstName" name="lastName" name="phone">The details of the member to be checked.</param>
        /// <returns>
        /// True if no existing member matches the provided details; otherwise, false.
        /// </returns>
        public static bool IsExistingMember(string firstName, string lastName, string phone)
        {
            string sqlQuery = $"SELECT COUNT(*) FROM Members WHERE First_Name = '{firstName}' AND Last_Name = '{lastName}' AND Phone = '{phone}'";
            OracleDataReader dr = Database.ExecuteSingleRowQuery(sqlQuery);

            dr.Read();
            int count = dr.GetInt32(0);
            return count > 0;
        }
    }
}
