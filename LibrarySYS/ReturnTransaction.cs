using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySYS
{
    public class ReturnTransaction : Transaction
    {
        public int LoanID { get; set; }

        public ReturnTransaction(int loanId, int memberId) : base(memberId)
        {
            LoanID = loanId;
        }
        public override void processTransaction()
        {
            string updateLoanQuery = $"UPDATE Loans SET Return_Date = TO_DATE('{DateTime.Now:dd-MM-yyyy}', 'DD-MM-YYYY') " +
                                     $"WHERE Loan_ID = {LoanID}";
            Database.ExecuteNonQuery(updateLoanQuery);
        }
    }
}
