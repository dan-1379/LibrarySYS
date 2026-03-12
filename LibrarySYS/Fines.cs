using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            string sqlQuery = $"SELECT NVL(SUM(f.FINE_AMOUNT), 0) " +
                              $"FROM Fines f " +
                              $"JOIN Loans l ON f.LOAN_ID = l.LOAN_ID " +
                              $"WHERE l.MEMBER_ID = {memberID} AND f.STATUS = 'U'";

            OracleDataReader dr = Database.ExecuteSingleRowQuery(sqlQuery);
            double total = 0.0;
            if (dr.Read())
            {
                total = Convert.ToDouble(dr[0]);
            }
            dr.Close();
            return total;
        }
    }
}
