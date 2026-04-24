using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySYS
{
    public class LoanTransaction : Transaction
    {
        public int LoanID { get; set; }
        public DateTime LoanDate { get; set; }
        public DateTime DueDate { get; set; }

        public LoanTransaction(int loanId, int memberId) : base(memberId)
        {
            LoanID = GetNextLoanId();
            LoanDate = DateTime.Now;
            DueDate = CalculateDueDate(DateTime.Now.AddDays(5));
        }
        public override void ProcessTransaction()
        {
            string sqlQuery = $"INSERT INTO Loans (Loan_ID, Member_ID, Loan_Date, Due_Date) VALUES ({LoanID}, {MemberID}, TO_DATE('{LoanDate:dd-MM-yyyy}', 'DD-MM-YYYY'), TO_DATE('{DueDate:dd-MM-yyyy}', 'DD-MM-YYYY'))";
            Database.ExecuteNonQuery(sqlQuery);
        }

        private DateTime CalculateDueDate(DateTime date)
        {
            if (date.DayOfWeek == DayOfWeek.Sunday)
            {
                date = date.AddDays(1);
            }

            return date;
        }

        public static int GetNextLoanId()
        {
            string sqlQuery = "SELECT MAX(Loan_ID) FROM Loans";
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
