using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace LibrarySYS
{
    public class Member
    {
        public int MemberID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DOB { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string County { get; set; }
        public string Eircode { get; set; }
        public DateTime RegistrationDate { get; set; }

        public char Status { get; set; }

        public Member(int memberID, string firstName, string lastName, DateTime dob,
                      string phone, string email, string addressLine1, string addressLine2,
                      string city, string county, string eircode)
        {
            MemberID = memberID;
            FirstName = firstName;
            LastName = lastName;
            DOB = dob;
            Phone = phone;
            Email = email;
            AddressLine1 = addressLine1;
            AddressLine2 = addressLine2;
            City = city;
            County = county;
            Eircode = eircode;
            RegistrationDate = DateTime.Now;
            Status = 'A';
        }

        public Member(int memberID, string firstName, string lastName, DateTime dob,
                      string phone, string email, string addressLine1, string addressLine2,
                      string city, string county, string eircode, char status)
        {
            MemberID = memberID;
            FirstName = firstName;
            LastName = lastName;
            DOB = dob;
            Phone = phone;
            Email = email;
            AddressLine1 = addressLine1;
            AddressLine2 = addressLine2;
            City = city;
            County = county;
            Eircode = eircode;
            RegistrationDate = DateTime.Now;
            Status = status;
        }

        public override string ToString()
        {
            return
                "Member ID: " + MemberID +
                ", First Name: " + FirstName +
                ", Last Name: " + LastName +
                ", DOB: " + DOB +
                ", Phone: " + Phone +
                ", Email: " + Email +
                ", Address Line 1: " + AddressLine1 +
                ", Address Line 2: " + AddressLine2 +
                ", City: " + City +
                ", County: " + County +
                ", Eircode: " + Eircode +
                ", Registration Date: " + RegistrationDate;
        }

        public static int GetNextMemberID()
        {
            string sqlQuery = "SELECT MAX(Member_ID) FROM Members";
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

        public static DataSet getAllMembers()
        {
            string sqlQuery = "SELECT Member_ID, First_Name, Last_Name, DOB, Phone, Email, Address_Line1, Address_Line2, City, County, Eircode, Registration_Date, " +
                              "Status FROM Members ORDER BY Member_ID";
            return Database.ExecuteMultiRowQuery(sqlQuery);
        }

        /*
         * Title: How to make a parameterized SELECT query in C#?
         * Author: Paweł Żelazny
         * Site: stackoverflow.com
         * Date: May 4, 2019
         * Code Version: N/A
         * Availability: https://stackoverflow.com/questions/55978404/how-to-make-a-parameterized-select-query-in-c
         * Accessed: 21 April 2026
         * Modified: Learned how to use parameterized queries.
        */
        public static Member GetMemberRecord(string ID)
        {
            string sqlQuery = @"SELECT Member_ID, First_Name, Last_Name, DOB, Phone, Email, Address_Line1, Address_Line2, City, County, Eircode, Registration_Date, Status FROM Members WHERE Member_ID = :MemberID";

            using (OracleConnection conn = Database.OpenConnection())
            using (OracleCommand cmd = new OracleCommand(sqlQuery, conn))
            {
                cmd.Parameters.Add("MemberID", OracleDbType.Varchar2).Value = ID;

                using (OracleDataReader member = cmd.ExecuteReader())
                {
                    if (member == null || !member.Read())
                    {
                        member?.Close();
                        return null;
                    }

                    Member result = new Member(
                        Convert.ToInt32(member["Member_ID"]),
                        member["First_Name"].ToString(),
                        member["Last_Name"].ToString(),
                        Convert.ToDateTime(member["DOB"]),
                        member["Phone"].ToString(),
                        member["Email"].ToString(),
                        member["Address_Line1"].ToString(),
                        member["Address_Line2"].ToString(),
                        member["City"].ToString(),
                        member["County"].ToString(),
                        member["Eircode"].ToString(),
                        Convert.ToChar(member["Status"])
                    );
    
                    return result;
                }
            }
        }

        public void AddMember()
        {
            string sqlQuery = @"INSERT INTO Members (Member_ID, First_Name, Last_Name, DOB, Phone, Email, Address_Line1, Address_Line2, City, County, Eircode, Registration_Date, Status) 
                                VALUES (:memberId, :firstName, :lastName, :dob, :phone, :email, :addressLine1, :addressLine2, :city, :county, :eircode, :registrationDate, :status)";

            using (OracleConnection conn = Database.OpenConnection())
            using (OracleCommand cmd = new OracleCommand(sqlQuery, conn))
            {
                cmd.Parameters.Add("memberId", OracleDbType.Int32).Value = MemberID;
                cmd.Parameters.Add("firstName", OracleDbType.Varchar2).Value = FirstName;
                cmd.Parameters.Add("lastName", OracleDbType.Varchar2).Value = LastName;
                cmd.Parameters.Add("dob", OracleDbType.Date).Value = DOB;
                cmd.Parameters.Add("phone", OracleDbType.Varchar2).Value = Phone;
                cmd.Parameters.Add("email", OracleDbType.Varchar2).Value = Email;
                cmd.Parameters.Add("addressLine1", OracleDbType.Varchar2).Value = AddressLine1;
                cmd.Parameters.Add("addressLine2", OracleDbType.Varchar2).Value = AddressLine2;
                cmd.Parameters.Add("city", OracleDbType.Varchar2).Value = City;
                cmd.Parameters.Add("county", OracleDbType.Varchar2).Value = County;
                cmd.Parameters.Add("eircode", OracleDbType.Varchar2).Value = Eircode;
                cmd.Parameters.Add("registrationDate", OracleDbType.Date).Value = RegistrationDate;
                cmd.Parameters.Add("status", OracleDbType.Char).Value = Status;
                cmd.ExecuteNonQuery();
            }
        }

        public static void AlterMemberStatus(string MemberID)
        {
            string sqlQuery = @"UPDATE Members SET Status = 'I' WHERE Member_ID = :MemberID";

            using (OracleConnection conn = Database.OpenConnection())
            using (OracleCommand cmd = new OracleCommand(sqlQuery, conn))
            {
                cmd.Parameters.Add("MemberID", OracleDbType.Varchar2).Value = MemberID;
                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateMemberDetails(string MemberID)
        {
            string sqlQuery = @"UPDATE Members SET First_Name = :firstName, Last_Name = :lastName, DOB = :dob, Phone = :phone, Email = :email, Address_Line1 = :addressLine1, 
                                Address_Line2 = :addressLine2, City = :city, County = :county, Eircode = :eircode, Status = :status, Registration_Date = :registrationDate WHERE Member_ID = :memberId";

            using (OracleConnection conn = Database.OpenConnection())
            using (OracleCommand cmd = new OracleCommand(sqlQuery, conn))
            {
                cmd.Parameters.Add("firstName", OracleDbType.Varchar2).Value = FirstName;
                cmd.Parameters.Add("lastName", OracleDbType.Varchar2).Value = LastName;
                cmd.Parameters.Add("dob", OracleDbType.Date).Value = DOB;
                cmd.Parameters.Add("phone", OracleDbType.Varchar2).Value = Phone;
                cmd.Parameters.Add("email", OracleDbType.Varchar2).Value = Email;
                cmd.Parameters.Add("addressLine1", OracleDbType.Varchar2).Value = AddressLine1;
                cmd.Parameters.Add("addressLine2", OracleDbType.Varchar2).Value = AddressLine2;
                cmd.Parameters.Add("city", OracleDbType.Varchar2).Value = City;
                cmd.Parameters.Add("county", OracleDbType.Varchar2).Value = County;
                cmd.Parameters.Add("eircode", OracleDbType.Varchar2).Value = Eircode;
                cmd.Parameters.Add("status", OracleDbType.Char).Value = Status;
                cmd.Parameters.Add("registrationDate", OracleDbType.Date).Value = RegistrationDate;
                cmd.Parameters.Add("memberId", OracleDbType.Int32).Value = MemberID;

                cmd.ExecuteNonQuery();
            }
        }
        /* END OF REFERENCED CONTENT */
    }
}
