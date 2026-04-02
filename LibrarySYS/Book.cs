using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LibrarySYS
{
    public class Book
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

        public Book(int bookID, string title, string author, string description,
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
                    ", Publication: " + Publication +
                    ", Status: " + Status;
        }

        public static int GetNextBookID()
        {
            string sqlQuery = "SELECT MAX(Book_ID) FROM Books";
            OracleDataReader dr = Database.ExecuteSingleRowQuery(sqlQuery);

            int nextId;
            dr.Read();

            if (dr.IsDBNull(0))
            {
                nextId = 1;
            }
            else
            {
                nextId = Convert.ToInt32(dr.GetDecimal(0) + 1);
            }

            dr.Close();
            return nextId;
        }

        public void AddBook()
        {
            Debug.WriteLine("Adding book: " + this);

            string sqlQuery =
                "INSERT INTO Books (Book_ID, Title, Author, Description, ISBN, Genre, Publisher, Publication_Date, Status) " +
                "VALUES (" + BookID + ", '" + Title + "', '" + Author + "', '" + Description + "', '" + ISBN + "', '" + Genre + "', '" + 
                        Publisher + "', TO_DATE('" + Publication.ToString("yyyy-MM-dd") + "', 'YYYY-MM-DD'), '" + Status + "')";


            Database.ExecuteNonQuery(sqlQuery);
        }

        public static void UpdateBookStatus(int bookID, char status)
        {
            string sqlQuery = $"UPDATE Books SET Status = '{status}' WHERE Book_ID = {bookID}";
            Database.ExecuteNonQuery(sqlQuery);
        }

        public void UpdateBook(string isbn)
        {
            string sqlQuery =
                "UPDATE Books SET " +
                "Title = '" + Title + "', " +
                "Author = '" + Author + "', " +
                "Description = '" + Description + "', " +
                "Genre = '" + Genre + "', " +
                "Publisher = '" + Publisher + "', " +
                "Publication_Date = TO_DATE('" + Publication.ToString("yyyy-MM-dd") + "', 'YYYY-MM-DD'), " +
                "Status = '" + Status + "' " +
                "WHERE ISBN = '" + isbn + "'";
            Database.ExecuteNonQuery(sqlQuery);
        }

        public static Book GetBook(string ISBN)
        {
            string sqlQuery = "SELECT * FROM Books WHERE ISBN = '" + ISBN + "'";
            OracleDataReader book = Database.ExecuteSingleRowQuery(sqlQuery);

            if (book == null || !book.Read())
            {
                book?.Close();
                return null;
            }

            Book fetchedBook = new Book(
                Convert.ToInt32(book["Book_ID"]),
                book["Title"].ToString(),
                book["Author"].ToString(),
                book["Description"].ToString(),
                book["ISBN"].ToString(),
                book["Genre"].ToString(),
                book["Publisher"].ToString(),
                Convert.ToDateTime(book["Publication_Date"]),
                Convert.ToChar(book["Status"])
            );

            book.Close();
            return fetchedBook;
        }


        public static Dictionary<string, int> GetBooksByGenre()
        {
            Dictionary<string, int> genreCounts = new Dictionary<string, int>();

            string sql = "SELECT Genre, COUNT(*) " +
                         "FROM Books " +
                         "GROUP BY Genre";

            OracleDataReader dr = Database.ExecuteSingleRowQuery(sql);

            while (dr.Read())
            {
                string genre = dr[0].ToString();
                int count = Convert.ToInt32(dr[1]);
                genreCounts[genre] = count;
            }

            dr.Close();
            return genreCounts;
        }
    }
}
