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
        public int Loan_ID { get; set; }
        public int Book_ID { get; set; }
        public DateTime? Return_Date { get; set; }

        public LoanItem(int bookId, int loanId)
        {
            Loan_ID = loanId;
            Book_ID = bookId;
            Return_Date = null;
        }

        public void AddLoanItem()
        {
            string sqlQuery = $"INSERT INTO LoanItems (Loan_ID, Book_ID) VALUES ({Loan_ID}, {Book_ID})";
            Database.ExecuteNonQuery(sqlQuery);
        }

        public static int fetchUnreturnedBooks(int memberID)
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

        public static int fetchOverdueBooksCount(int memberID)
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
    }
}
