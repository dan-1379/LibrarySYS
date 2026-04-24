using Oracle.ManagedDataAccess.Client;
using System;

namespace LibrarySYS
{
    public class Fine
    {
        public int ID { get; set; }
        public double FineAmount { get; set; }
        public char Status { get; set; }
        public int LoanID { get; set; }
        public int BookID { get; set; }

        public Fine(double fineAmount, int loanID, int bookID)
        {
            FineAmount = fineAmount;
            LoanID = loanID;
            BookID = bookID;
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
            double total = 0;
            if (dr.Read())
            {
                total = Convert.ToDouble(dr[0]);
            }
            dr.Close();
            return total;
        }

        public static void AlterFineStatus(int memberID, char newStatus)
        {
            string sqlQuery = $"UPDATE Fines " +
                              $"SET STATUS = '{newStatus}' " +
                              $"WHERE Loan_ID IN (SELECT Loan_ID FROM LOANS WHERE MEMBER_ID = {memberID})";
            Database.ExecuteNonQuery(sqlQuery);
        }

        public void InsertFine()
        {
            int nextFineID = GetNextFineID();
            /*
             * Title: System.Globalization.CultureInfo.InvariantCulture property
             * Author: Microsoft Corporation
             * Site: learn.microsoft.com
             * Date: 24 April 2026
             * Code Version: N/A
             * Availability: https://learn.microsoft.com/en-us/dotnet/fundamentals/runtime-libraries/system-globalization-cultureinfo-invariantculture
             * Accessed: 24 April 2026
             * Modified: Using the InvariantCulture property to ensure that the decimal separator is a dot (.) regardless of the system's culture settings, which is important for SQL queries.
            */
            string fine = ((decimal)FineAmount).ToString("F2", System.Globalization.CultureInfo.InvariantCulture);
            /* END OF REFERENCED CONTENT */

            string sqlQuery = $"INSERT INTO Fines (Fine_ID, Fine_Amount, Status, Loan_ID, Book_ID) " +
                              $"VALUES ({nextFineID}, {fine}, '{Status}', {LoanID}, {BookID})";
            Database.ExecuteNonQuery(sqlQuery);
        }

        public static double[] GetFinesByMonth(int year)
        {
            double[] finesByMonth = new double[12];

            string sql = "SELECT EXTRACT(MONTH FROM l.Loan_Date) , SUM(Fine_Amount) " +
                         "FROM Fines f " +
                         "JOIN Loans l ON f.Loan_ID = l.Loan_ID " +
                         $"WHERE EXTRACT(YEAR FROM l.Loan_Date) = {year} " +
                         "GROUP BY EXTRACT(MONTH FROM l.Loan_Date)";

            OracleDataReader dr = Database.ExecuteSingleRowQuery(sql);

            while (dr.Read())
            {
                int monthIndex = Convert.ToInt32(dr[0]);
                double fineAmount = Convert.ToDouble(dr[1]);

                finesByMonth[monthIndex - 1] = fineAmount;
            }

            dr.Close();

            return finesByMonth;
        }
    }
}
