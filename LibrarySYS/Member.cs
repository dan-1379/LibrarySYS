using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            string sqlQuery = "SELECT Member_ID, First_Name, Last_Name, DOB, Phone, Email, Address_Line1, Address_Line2, City, County, Eircode, Registration_Date, Status FROM Members ORDER BY Member_ID";
            return Database.ExecuteMultiRowQuery(sqlQuery);
        }

        public static Member GetMemberRecord(string ID)
        {
            string sql = "SELECT Member_ID, First_Name, Last_Name, DOB, Phone, Email, Address_Line1, Address_Line2, City, County, Eircode, Registration_Date, Status FROM Members WHERE Member_ID = '" + ID + "'";
            OracleDataReader member = Database.ExecuteSingleRowQuery(sql);

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

            member.Close();
            return result;
        }

        public void AddMember()
        {
            string sqlQuery = "INSERT INTO Members (Member_ID, First_Name, Last_Name, DOB, Phone, Email, Address_Line1, Address_Line2, City, County, Eircode, Registration_Date, Status) " +
                              "VALUES (" + MemberID + ", '" + FirstName + "', '" + LastName + "', TO_DATE('" + DOB.ToString("yyyy-MM-dd") + "', 'YYYY-MM-DD'), '" + Phone + "', '" + Email +
                              "', '" + AddressLine1 + "', '" + AddressLine2 + "', '" + City + "', '" + County + "', '" + Eircode + "', TO_DATE('" + RegistrationDate.ToString("yyyy-MM-dd") + "', 'YYYY-MM-DD'), '" + Status + "')";

            Database.ExecuteMultiRowQuery(sqlQuery);
        }

        public static void AlterMemberStatus(string MemberID)
        {
            string sqlQuery = "UPDATE Members SET Status = 'I' WHERE Member_ID = '" + MemberID + "'";
            Database.ExecuteSingleRowQuery(sqlQuery);
        }

        public void UpdateMemberDetails(string MemberID)
        {
            string sqlQuery = "UPDATE Members SET " +
                              "First_Name = '" + FirstName + "', " +
                              "Last_Name = '" + LastName + "', " +
                              "DOB = TO_DATE('" + DOB.ToString("yyyy-MM-dd") + "', 'YYYY-MM-DD'), " +
                              "Phone = '" + Phone + "', " +
                              "Email = '" + Email + "', " +
                              "Address_Line1 = '" + AddressLine1 + "', " +
                              "Address_Line2 = '" + AddressLine2 + "', " +
                              "City = '" + City + "', " +
                              "County = '" + County + "', " +
                              "Eircode = '" + Eircode + "', " +
                              "Status = '" + Status + "', " +
                              "Registration_Date = TO_DATE('" + RegistrationDate.ToString("yyyy-MM-dd") + "', 'YYYY-MM-DD') " +
                              "WHERE Member_ID = " + MemberID;

            Database.ExecuteMultiRowQuery(sqlQuery);
        }
    }
}
