using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LibrarySYS
{
    public class CardValidator
    {
        public static string IsValidCardNumber(string cardNumber)
        {
            if (string.IsNullOrWhiteSpace(cardNumber))
            {
                return "Card number cannot be empty";
            }

            if (cardNumber.Length != 19)
            {
                return "Card number must be 19 characters long (including hyphens)";
            }

            string[] parts = cardNumber.Split('-');

            if (parts.Length != 4)
            {
                return "Card number must be in the format XXXX-XXXX-XXXX-XXXX";
            }

            int validPartCount = 0;

            foreach (string part in parts)
            {
                if (part.Length == 4)
                {
                    validPartCount++;
                }
            }

            if (validPartCount != 4)
            {
                return "Each part of the card number must be 4 digits long";
            }

            cardNumber = cardNumber.Replace("-", "");

            if (!cardNumber.All(char.IsDigit))
            {
                return "Card number must contain only digits";
            }

            return "valid";
        }

        public static string IsValidExpiryDate(string expiryDate)
        {
            if (string.IsNullOrWhiteSpace(expiryDate))
            {
                return "Expiry date cannot be empty";
            }

            if (expiryDate.Length != 5)
            {
                return "Expiry date must be in the format MM/YY";
            }

            if (expiryDate[2] != '/')
            {
                return "Expiry date must contain forward slash";
            }

            string[] parts = expiryDate.Split('/');

            if (parts.Length != 2)
            {
                return "Expiry date must be in the format MM/YY";
            }

            foreach(string part in parts)
            {
                if (!part.All(char.IsDigit))
                {
                    return "Expiry date must contain only digits";
                }
            }

            int month = int.Parse(parts[0]);
            int year = int.Parse(parts[1]);

            if (month < 1 || month > 12)
            {
                return "Expiry month must be between 01 and 12";
            }

            int currentYear = DateTime.Now.Year % 100;
            int currentMonth = DateTime.Now.Month;

            if (year < currentYear || (year == currentYear && month < currentMonth))
            {
                return "Card is expired.";
            }


            return "valid";
        }

        public static string IsValidCardholderName(string cardholderName)
        {
            if (string.IsNullOrWhiteSpace(cardholderName))
            {
                return "Cardholder name cannot be empty";
            }

            Regex regex = new Regex(@"^[a-zA-Z\s]+$");

            if (!regex.IsMatch(cardholderName))
            {
                return "Cardholder name must contain only letters and spaces";
            }

            return "valid";
        }

        public static string IsValidCVV(string cvv)
        {
            if (string.IsNullOrWhiteSpace(cvv))
            {
                return "CVV cannot be empty";
            }

            if (cvv.Length != 3)
            {
                return "CVV must be 3 digits long";
            }

            if (!cvv.All(char.IsDigit))
            {
                return "CVV must contain only digits";
            }

            return "valid";
        }
    }
}
