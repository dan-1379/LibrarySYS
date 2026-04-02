using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrarySYS
{
    public class ReturnTransaction : Transaction
    {
        public int LoanID { get; set; }
        public int BookID { get; set; }
        private const double FinePerDay = 0.20;

        public ReturnTransaction(int loanId, int bookID, int memberId) : base(memberId)
        {
            LoanID = loanId;
            BookID = bookID;
        }
        public override void processTransaction()
        {
            DateTime dueDate = getDueDate(LoanID);

            string updateLoanQuery = $"UPDATE LoanItems SET ReturnDate = SYSDATE WHERE Loan_ID = {LoanID} AND Book_ID = {BookID}";
            Database.ExecuteNonQuery(updateLoanQuery);

            if (dueDate < DateTime.Today)
            {
                int daysOverdue = (DateTime.Today - dueDate).Days;
                double fineAmount = daysOverdue * FinePerDay;

                Fine newFine = new Fine(fineAmount, LoanID, BookID);
                newFine.insertFine();

                MessageBox.Show($"Books overdue by: {daysOverdue}. Fine of {fineAmount} recorded.");
            }
        }

        private DateTime getDueDate(int loanID)
        {
            string sql = $"SELECT Due_Date FROM Loans WHERE Loan_ID = {LoanID}";

            OracleDataReader result = Database.ExecuteSingleRowQuery(sql);
            result.Read();
            return Convert.ToDateTime(result[0]);
        }
    }
}
