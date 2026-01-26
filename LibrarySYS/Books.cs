using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySYS
{
    public class Books
    {
        public int BookID { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }
        public string ISBN { get; set; }
        public string Genre { get; set; }
        public string Publisher { get; set; }
        public DateTime Publication { get; set; }
        public char Status { get; set; }

        public Books() : this(0, "", "", "", "", "", "", DateTime.Now, 'A') { }

        public Books(int bookID, string title, string author, string description,
                     string isbn, string genre, string publisher,
                     DateTime publication, char status)
        {
            BookID = bookID;
            Title = title;
            Author = author;
            Description = description;
            ISBN = isbn;
            Genre = genre;
            Publisher = publisher;
            Publication = publication;
            Status = status;
        }

        public override string ToString()
        {
          return    "Book ID: " + BookID +
                    ", Title: " + Title +
                    ", Author: " + Author +
                    ", Description: " + Description +
                    ", ISBN: " + ISBN +
                    ", Genre: " + Genre +
                    ", Publisher: " + Publisher +
                    ", Publication: " + Publication.ToShortDateString() +
                    ", Status: " + Status;
        }

        public static DataSet GetAllBooks(string ISBN)
        {
            string sqlQuery = "SELECT * FROM Books WHERE ISBN = " + ISBN;
            return Database.ExecuteMultiRowQuery(sqlQuery);
        }
    }
}
