using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySYS
{
    public abstract class Transaction
    {
        public int MemberID { get; set; }
        public DateTime TransactionDate { get; set; }

        public Transaction(int memberID)
        {
            MemberID = memberID;
            TransactionDate = DateTime.Now;
        }
        public abstract void processTransaction();
    }
}
