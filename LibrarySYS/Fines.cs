using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySYS
{
    public class Fines
    {
        public int Fine_ID { get; set; }
        public double Fine_Amount { get; set; }
        public char Status { get; set; }
        public int Loan_ID { get; set; }
        public int Book_ID { get; set; }

        public Fines(double fineAmount, int loanID, int bookID) { 
            Fine_Amount = fineAmount;
            Loan_ID = loanID;
            Book_ID = bookID;
            Status = 'U';
        }

        public static int GetNextFineID()
        {
            string sqlQuery = "SELECT MAX(Fine_ID) FROM Fines";
            OracleDataReader dr = Database.ExecuteSingleRowQuery(sqlQuery);
            int nextId;
            dr.Read();
            if (dr.IsDBNull(0))
            {
                nextId = 1;
            }
            else
            {
                nextId = dr.GetInt32(0) + 1;
            }
            dr.Close();
            return nextId;
        }

        public static double GetOutstandingFines(int memberID)
        {
            string sqlQuery = $"SELECT NVL(SUM(f.FINE_ID), 0), f.FINE_AMOUNT, f.STATUS, f.LOAN_ID, f.BOOK_ID " +
                              $"FROM Fines f " +
                              $"JOIN LoanItems li ON f.LOAN_ID = li.LOAN_ID " +
                              $"JOIN Loans l ON li.LOAN_ID = l.LOAN_ID " +
                              $"WHERE l.Member_ID = {memberID} AND f.STATUS = 'U'";
            
            OracleDataReader dr = Database.ExecuteSingleRowQuery(sqlQuery);
            double total = 0.0;
            if (dr.Read())
            {
                total = dr.GetDouble(0);
            }
            dr.Close();
            return total;
        }
    }
}
