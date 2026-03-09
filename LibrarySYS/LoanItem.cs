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

        public LoanItem(int bookId)
        {
            Loan_ID = GetNextLoanID();
            Book_ID = bookId;
            Return_Date = null;
        }

        public void AddLoanItem()
        {
            string sqlQuery = $"INSERT INTO LoanItems (Loan_ID, Book_ID) VALUES ({Loan_ID}, {Book_ID})";
            Database.ExecuteNonQuery(sqlQuery);
        }

        public static int GetNextLoanID()
        {
            string sqlQuery = "SELECT MAX(Loan_ID) FROM LoanItems";
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
    }
}
