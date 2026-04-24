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
        public int ID { get; set; }
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
            ID = bookID;
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
          return    "Book ID: " + ID +
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

        /*
         * Title: How to make a parameterized SELECT query in C#?
         * Author: Paweł Żelazny
         * Site: stackoverflow.com
         * Date: May 4, 2019
         * Code Version: N/A
         * Availability: https://stackoverflow.com/questions/55978404/how-to-make-a-parameterized-select-query-in-c
         * Accessed: 21 April 2026
         * Modified: Learned how to use parameterized queries.
        */
        public void AddBook()
        {
            string sqlQuery = @"INSERT INTO Books (Book_ID, Title, Author, Description, ISBN, Genre, Publisher, Publication_Date, Status)
                        VALUES (:bookId, :title, :author, :description, :isbn, :genre, :publisher, :pubDate, :status)";

            using (OracleConnection conn = Database.OpenConnection())
            using (OracleCommand cmd = new OracleCommand(sqlQuery, conn))
            {
                cmd.Parameters.Add("bookId", OracleDbType.Int32).Value = ID;
                cmd.Parameters.Add("title", OracleDbType.Varchar2).Value = Title;
                cmd.Parameters.Add("author", OracleDbType.Varchar2).Value = Author;
                cmd.Parameters.Add("description", OracleDbType.Varchar2).Value = Description;
                cmd.Parameters.Add("isbn", OracleDbType.Varchar2).Value = ISBN;
                cmd.Parameters.Add("genre", OracleDbType.Varchar2).Value = Genre;
                cmd.Parameters.Add("publisher", OracleDbType.Varchar2).Value = Publisher;
                cmd.Parameters.Add("pubDate", OracleDbType.Date).Value = Publication;
                cmd.Parameters.Add("status", OracleDbType.Char).Value = Status;

                cmd.ExecuteNonQuery();
            }
        }

        public static void UpdateBookStatus(int bookID, char status)
        {
            string sqlQuery = @"UPDATE Books SET Status = :status WHERE Book_ID = :bookId";

            using (OracleConnection conn = Database.OpenConnection())
            using (OracleCommand cmd = new OracleCommand(sqlQuery, conn))
            {
                cmd.Parameters.Add("status", OracleDbType.Char).Value = status;
                cmd.Parameters.Add("bookId", OracleDbType.Int32).Value = bookID;
                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateBook(string isbn)
        {
            string sqlQuery = @"UPDATE Books SET Title = :title, Author = :author, Description = :description, Genre = :genre, Publisher = :publisher, 
                                Publication_Date = :pubDate, Status = :status WHERE ISBN = :isbn";

            using (OracleConnection conn = Database.OpenConnection())
            using (OracleCommand cmd = new OracleCommand(sqlQuery, conn))
            {
                cmd.Parameters.Add("title", OracleDbType.Varchar2).Value = Title;
                cmd.Parameters.Add("author", OracleDbType.Varchar2).Value = Author;
                cmd.Parameters.Add("description", OracleDbType.Varchar2).Value = Description;
                cmd.Parameters.Add("genre", OracleDbType.Varchar2).Value = Genre;
                cmd.Parameters.Add("publisher", OracleDbType.Varchar2).Value = Publisher;
                cmd.Parameters.Add("pubDate", OracleDbType.Date).Value = Publication;
                cmd.Parameters.Add("status", OracleDbType.Char).Value = Status;
                cmd.Parameters.Add("isbn", OracleDbType.Varchar2).Value = isbn;
                cmd.ExecuteNonQuery();
            }
        }

        public static Book GetBook(string ISBN)
        {
            string sqlQuery = @"SELECT * FROM Books WHERE ISBN = :isbn";

            OracleDataReader book;

            using (OracleConnection conn = Database.OpenConnection())
            using (OracleCommand cmd = new OracleCommand(sqlQuery, conn))
            {
                cmd.Parameters.Add("isbn", OracleDbType.Varchar2).Value = ISBN;
                book = cmd.ExecuteReader();

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

                return fetchedBook;
            }
        }
        /* END OF REFERENCED CONTENT */


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
