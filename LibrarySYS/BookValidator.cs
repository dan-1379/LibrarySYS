using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace LibrarySYS
{
    /// <summary>
    /// Provides validation logic for book-related data within the Library System.
    /// This class is responsible for validating individual book fields such as
    /// title, author, ISBN, publication date, and publisher, as well as enforcing
    /// business rules such as ISBN uniqueness.
    /// </summary>
    public class BookValidator
    {
        /// <summary>
        /// Determines if the provided book title is valid.
        /// </summary>
        /// <param name="title">The book title to be validated.</param>
        /// <returns>
        /// True if the title is non-empty and does not exceed 30 characters; 
        /// otherwise, false.
        /// </returns>
        public static bool IsValidTitle(string title)
        {
            return !string.IsNullOrWhiteSpace(title) && title.Length <= 30;
        }

        /// <summary>
        /// Determines if the provided author is valid.
        /// </summary>
        /// <param name="author">The author of the book.</param>
        /// <returns>
        /// True if the author is non-empty and does not exceed 25 characters;
        /// otherwise, false.
        /// </returns>
        public static bool IsValidAuthor(string author)
        {
            return !string.IsNullOrWhiteSpace(author) && author.Length <= 25;
        }

        /// <summary>
        /// Determines if the provided book description is valid.
        /// </summary>
        /// <param name="description">The description of the book.</param>
        /// <returns>
        /// True if the description is non-empty and does not exceed 30 characters;
        /// otherwise, false.
        /// </returns>
        public static bool IsValidDescription(string description)
        {
            return !string.IsNullOrWhiteSpace(description) && description.Length <= 30;
        }

        /// <summary>
        /// Determines if the provided ISBN is valid according to ISBN-13 standards.
        /// </summary>
        /// <param name="isbn">The ISBN of the book.</param>
        /// <returns>
        /// True if the ISBN is valid; False if any the validation checks fail.
        /// </returns>
        public static string IsValidISBN(string isbn)
        {
            if (string.IsNullOrWhiteSpace(isbn)) 
            {
                return "ISBN must not be null or contain only whitespaces";
            }

            if (isbn.Length != 17)
            {
                return "ISBN must be of length 17";
            }

            /* https://stackoverflow.com/questions/12350801/check-string-for-invalid-characters-smartest-way */
            Regex r = new Regex("^[0-9-]+$"); // REFERENCE THIS LATER

            if (!r.IsMatch(isbn))
            {
                return "ISBN must only contain numbers and dashes";
            }

            string[] sections = isbn.Split('-');

            if (sections.Length != 5)
            {
                return "ISBN must contain 5 sections";
            }

            string prefix = sections[0];
            string registrationGroup = sections[1];
            string registrant = sections[2];
            string publication = sections[3];
            string checkDigit = sections[4];

            if (prefix != "978" && prefix != "979")
            {
                return "ISBN must begin with '978' or '979'";
            }

            if (registrationGroup.Length < 1 || registrationGroup.Length > 5)
            {
                return "Registration Group should be of length 1-5";
            }

            if (registrant.Length < 1 || registrant.Length > 7)
            {
                return "Registrant should be of length 1-7";
            }

            if (publication.Length < 1 || publication.Length > 7)
            {
                return "Publication should be of length 1-7";
            }

            if (!IsValidCheckDigit(isbn))
            {
                return "Check digit of ISBN is invalid";
            }
            return "Valid ISBN";
        }

        /// <summary>
        /// Helper method to validate the check digit of an ISBN-13.
        /// This digit must be equal to the last digit in the ISBN.
        /// </summary>
        /// <param name="isbn">The ISBN of the book.</param>
        /// <returns>
        /// True if the check digit is valid; otherwise, false.
        /// </returns>
        public static bool IsValidCheckDigit(string isbn)
        {
            string digitsOnly = isbn.Replace("-", "");
            int sum = 0;
            int remainder;

            for (int i = 0; i < digitsOnly.Length - 1; i++)
            {
                int currentDigit = int.Parse(digitsOnly[i].ToString());

                if (i % 2 == 0)
                {
                    sum += currentDigit;
                }
                else
                {
                    sum += currentDigit * 3;
                }
            }

            remainder = (10 - (sum % 10)) % 10;

            if (!(remainder == int.Parse(digitsOnly[digitsOnly.Length - 1].ToString())))
            {
                return false;
            }

            return true;
        }

        /// <summary>
        /// Helper method to check if the provided ISBN is unique in the database.
        /// </summary>
        /// <param name="isbn">The ISBN of the book.</param>
        /// <returns>
        /// True if the ISBN is unique; otherwise, false.
        /// </returns>
        public static bool IsUniqueISBN(string isbn)
        {
            string sqlQuery = $"SELECT COUNT(*) FROM Books WHERE ISBN = '{isbn}'";
            OracleDataReader dr = Database.ExecuteSingleRowQuery(sqlQuery);

            dr.Read();
            int count = Convert.ToInt32(dr.GetDecimal(0));

            dr.Close();
            return count == 0;
        }

        /// <summary>
        /// Determines if the provided genre is valid.
        /// </summary>
        /// <param name="genre">The genre string to validate.</param>
        /// <returns>
        /// True if the genre is valid; otherwise false.
        /// </returns>
        public static bool IsValidGenre(string genre)
        {
            return !string.IsNullOrWhiteSpace(genre);
        }

        /// <summary>
        /// Determines if the provided publisher is valid.
        /// </summary>
        /// <param name="publisher">The publisher of the book.</param>
        /// <returns>
        /// True if the publisher is non-empty and does not exceed 25 characters; otherwise false.
        /// </returns>
        public static bool IsValidPublisher(string publisher)
        {
            return !string.IsNullOrWhiteSpace(publisher) && publisher.Length <= 25;
        }

        /// <summary>
        /// Determines if the provided publication date is valid.
        /// </summary>
        /// <param name="publicationDate">The publication date of the book.</param>
        /// <returns>
        /// True if the publication date is not in the future; otherwise false.
        /// </returns>
        public static bool IsValidPublicationDate(DateTime publicationDate)
        {
            return publicationDate <= DateTime.Today;
        }
    }
}
