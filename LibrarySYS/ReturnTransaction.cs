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
            // Implement the logic to process a return transaction
            // This could involve updating the book's status to available,
            // calculating any late fees, and recording the transaction details.
        }
    }
}
