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
        private const double FINE_PER_DAY = 0.20;

        public ReturnTransaction(int loanId, int bookID, int memberId) : base(memberId)
        {
            LoanID = loanId;
            BookID = bookID;
        }
        public override void ProcessTransaction()
        {
            DateTime dueDate = GetDueDate(LoanID);

            string updateLoanQuery = $"UPDATE LoanItems SET ReturnDate = SYSDATE WHERE Loan_ID = {LoanID} AND Book_ID = {BookID}";
            Database.ExecuteNonQuery(updateLoanQuery);

            if (dueDate < DateTime.Today)
            {
                int daysOverdue = (DateTime.Today - dueDate).Days;
                double fineAmount = daysOverdue * FINE_PER_DAY;

                Fine newFine = new Fine(fineAmount, LoanID, BookID);
                newFine.InsertFine();

                MessageBox.Show($"Books overdue by: {daysOverdue} days. Fine of {fineAmount} recorded.", "Overdue Book", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private DateTime GetDueDate(int loanID)
        {
            string sql = $"SELECT Due_Date FROM Loans WHERE Loan_ID = {LoanID}";

            OracleDataReader result = Database.ExecuteSingleRowQuery(sql);
            result.Read();
            return Convert.ToDateTime(result[0]);
        }
    }
}
