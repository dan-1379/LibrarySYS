using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySYS
{
    internal class BookValidator
    {
        public static bool IsValidTitle(string title)
        {
            return !string.IsNullOrWhiteSpace(title) && title.Length > 30;
        }

        public static bool IsValidAuthor(string author)
        {
            return !string.IsNullOrWhiteSpace(author) && author.Length > 25;
        }

        public static bool IsValidDescription(string description)
        {
            return !string.IsNullOrWhiteSpace(description) && description.Length > 30;
        }

        public static bool IsValidISBN(string isbn)
        {
            return false;
        }

        public static bool IsValidGenre(string genre)
        {
            return !string.IsNullOrWhiteSpace(genre);
        }

        public static bool IsValidPublisher(string publisher)
        {
            return !string.IsNullOrWhiteSpace(publisher) && publisher.Length > 25;
        }

        public static bool IsValidPublicationDate(DateTime publicationDate)
        {
            return publicationDate <= DateTime.Today;
        }
    }
}
