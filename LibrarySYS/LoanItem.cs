using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySYS
{
    public class LoanItem
    {
        public int ID { get; set; }
        public int BookID { get; set; }
        public DateTime? ReturnDate { get; set; }

        public LoanItem(int bookId, int loanId)
        {
            ID = loanId;
            BookID = bookId;
            ReturnDate = null;
        }

        public void AddLoanItem()
        {
            string sqlQuery = $"INSERT INTO LoanItems (Loan_ID, Book_ID) VALUES ({ID}, {BookID})";
            Database.ExecuteNonQuery(sqlQuery);
        }

        public static int FetchUnreturnedBooks(int memberID)
        {
            string sqlQuery = $"SELECT COUNT(*) " +
                              $"FROM LoanItems li " +
                              $"JOIN Loans l ON li.Loan_ID = l.Loan_ID " +
                              $"WHERE l.Member_ID = {memberID} AND li.ReturnDate IS NULL";
           
            OracleDataReader dr = Database.ExecuteSingleRowQuery(sqlQuery);

            int count = 0;
            if (dr.Read())
            {
                count = Convert.ToInt32(dr[0]);
            }
            dr.Close();
            return count;
        }

        public static int FetchOverdueBooksCount(int memberID)
        {
            string sqlQuery = $"SELECT COUNT(*) " +
                              $"FROM LoanItems li " +
                              $"JOIN Loans l ON li.Loan_ID = l.Loan_ID " +
                              $"WHERE l.Member_ID = {memberID} AND li.ReturnDate IS NULL AND l.Due_Date < SYSDATE";

            OracleDataReader dr = Database.ExecuteSingleRowQuery(sqlQuery);

            int count = 0;
            if (dr.Read())
            {
                count = Convert.ToInt32(dr[0]);
            }
            dr.Close();
            return count;
        }

        public static List<Book> GetUnreturnedBooks(int memberID)
        {
            string sqlQuery = $"SELECT b.* " +
                              $"FROM LoanItems li " +
                              $"JOIN Loans l ON li.Loan_ID = l.Loan_ID " +
                              $"JOIN Books b ON li.Book_ID = b.Book_ID " +
                              $"WHERE l.Member_ID = {memberID} AND li.ReturnDate IS NULL";

            OracleDataReader dr = Database.ExecuteSingleRowQuery(sqlQuery);
            List<Book> unreturnedBooks = new List<Book>();

            while (dr.Read())
            {
                Book book = new Book(
                    Convert.ToInt32(dr["BOOK_ID"]),
                    dr["TITLE"].ToString(),
                    dr["AUTHOR"].ToString(),
                    dr["DESCRIPTION"].ToString(),
                    dr["ISBN"].ToString(),
                    dr["GENRE"].ToString(),
                    dr["PUBLISHER"].ToString(),
                    Convert.ToDateTime(dr["PUBLICATION_DATE"]),
                    Convert.ToChar(dr["STATUS"])
                );

                unreturnedBooks.Add(book);
            }
            dr.Close();
            return unreturnedBooks;
        }

        public static int GetLoanID(int memberID, int bookID)
        {
            string sql = $"SELECT li.Loan_ID " +
                         $"FROM LoanItems li " +
                         $"JOIN Loans l ON li.Loan_ID = l.Loan_ID " +
                         $"WHERE l.Member_ID = {memberID} AND li.Book_ID = {bookID} AND li.ReturnDate IS NULL";

            OracleDataReader result = Database.ExecuteSingleRowQuery(sql);
            result.Read();
            return Convert.ToInt32(result[0]);
        }

        public static int FetchCurrentLoanCount(int memberID)
        {
            string sql = $"SELECT COUNT(*) " +
                         $"FROM LoanItems li " +
                         $"JOIN Loans l ON li.Loan_ID = l.Loan_ID " +
                         $"WHERE l.Member_ID = {memberID} AND li.ReturnDate IS NULL";
            
            OracleDataReader result = Database.ExecuteSingleRowQuery(sql);

            int count = 0;

            if (result.Read())
            {
                count = Convert.ToInt32(result[0]);
            }

            result.Close();
            return count;
        }
    }
}
