using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace LibrarySYS.Tests
{
    [TestClass]
    public class TestMemberValidator
    {
        [DataTestMethod]
        [DataRow(null, false)]
        [DataRow("     ", false)]
        [DataRow("John", true)]
        [DataRow("Maria de la Luz Rodriguez-Fernandez", false)]
        public void TestValidFirstName(string firstName, bool expected)
        {
            bool result = MemberValidator.IsValidFirstName(firstName);
            Assert.AreEqual(expected, result);
        }

        [DataTestMethod]
        [DataRow(null, false)]
        [DataRow("     ", false)]
        [DataRow("Smith", true)]
        [DataRow("O'Connor", true)]
        [DataRow("Maria de la Luz Rodriguez-Fernandez", false)]
        public void TestValidLastName(string lastName, bool expected)
        {
            bool result = MemberValidator.IsValidLastName(lastName);
            Assert.AreEqual(expected, result);
        }

        public void TestValidDOB()
        {
            DateTime validDOB = DateTime.Today.AddYears(-25);
            Assert.IsTrue(MemberValidator.IsValidDOB(validDOB));

            DateTime futureDOB = DateTime.Today.AddYears(1);
            Assert.IsFalse(MemberValidator.IsValidDOB(futureDOB));

            DateTime oldDOB = DateTime.Today.AddYears(-121);
            Assert.IsFalse(MemberValidator.IsValidDOB(oldDOB));

            DateTime exactly120 = DateTime.Today.AddYears(-120);
            Assert.IsTrue(MemberValidator.IsValidDOB(exactly120));
        }

        [DataTestMethod]
        [DataRow(null, "A phone number must be entered.")]
        [DataRow("     ", "A phone number must be entered.")]
        [DataRow("123456789", "The phone number must have 10 or 13 characters")]
        [DataRow("12345678901234", "The phone number must have 10 or 13 characters")]
        [DataRow("1234a67890", "The phone number must contain only numeric characters.")]
        [DataRow("0652483241", "Phone number must begin with 08 or 353")]
        [DataRow("0872643281", "valid")]
        [DataRow("353872643281", "valid")]
        public void TestValidPhone(string phone, string expected)
        {
            string result = MemberValidator.IsValidPhone(phone);
            Assert.AreEqual(expected, result);
        }

        [DataTestMethod]
        [DataRow("dcourtney", "Email length must be between 10 and 40.")]
        [DataRow("danieljamesandrewcourtneybusinesslogisticsaccount@gmail.com", "Email length must be between 10 and 40.")]
        [DataRow("danielcourtney.com", "Email must contain an @ symbol.")]
        [DataRow("daniel@courtney.bye", "Email must end with a valid domain (.com, .org, .ie, .net).")]
        [DataRow("daniel@courtney", "Email must end with a valid domain (.com, .org, .ie, .net).")]
        [DataRow("@courtney.com", "Recipient section of the email must be between 1 and 30 characters.")]
        [DataRow("danieljamesandrewcourtneybusiness@c.com", "Recipient section of the email must be between 1 and 30 characters.")]
        [DataRow("daniel~james@courtney.com", "Recipient section must only contain uppercase and lowercase letters, numbers, decimal points, dashes and underscores.")]
        [DataRow("daniel.courtney@.com", "Domain section of the email must be between 2 and 15 characters.")]
        [DataRow("daniel.courtney@courtneybusiness.com", "Domain section of the email must be between 2 and 15 characters.")]
        [DataRow("danielcourtney@courtn£ybusines.com", "Domain section must only contain uppercase and lowercase letters, numbers, decimal points, dashes and underscores.")]
        [DataRow("danielcourtney@courtneybusines.com", "valid")]
        public void TestValidEmail(string email, string expected)
        {
            string result = MemberValidator.IsValidEmail(email);
            Assert.AreEqual(expected, result);
        }

        [DataTestMethod]
        [DataRow(null, false)]
        [DataRow("     ", false)]
        [DataRow("123", false)]
        [DataRow("12345 Upper Main Street Tralee Kerry", false)]
        [DataRow("123 Main Street", true)]
        public void TestValidAddressLine1(string addressLine1, bool expected)
        {
            bool result = MemberValidator.IsValidAddressLine1(addressLine1);
            Assert.AreEqual(expected, result);
        }

        [DataTestMethod]
        [DataRow(null, true)]
        [DataRow("     ", true)]
        [DataRow("123", false)]
        [DataRow("12345 Upper Main Street Tralee Kerry", false)]
        [DataRow("Tralee", true)]
        public void TestValidAddressLine2(string addressLine2, bool expected)
        {
            bool result = MemberValidator.IsValidAddressLine2(addressLine2);
            Assert.AreEqual(expected, result);
        }

        [DataTestMethod]
        [DataRow(null, false)]
        [DataRow("     ", false)]
        [DataRow("abcdefghijklmnopqrstuvwxyzabcdefgh", false)]
        [DataRow("Tralee", true)]
        public void TestValidCity(string city, bool expected) 
        {
            bool result = MemberValidator.IsValidCity(city);
            Assert.AreEqual(expected, result);
        }

        [DataTestMethod]
        [DataRow(null, false)]
        [DataRow("     ", false)]
        [DataRow("Tip", false)]
        [DataRow("County Tipperary", false)]
        [DataRow("Kerry", true)]
        public void TestValidCounty(string county, bool expected)
        {
            bool result = MemberValidator.IsValidCounty(county);
            Assert.AreEqual(expected, result);
        }

        [DataTestMethod]
        [DataRow(null, "An Eircode must be entered.")]
        [DataRow("     ", "An Eircode must be entered.")]
        [DataRow("1234", "Eircode must be 7 characters long.")]
        [DataRow("12345678", "Eircode must be 7 characters long.")]
        [DataRow("1234567", "The first character of the routing key must be a letter.")]
        [DataRow("HY14567", "The second and third characters of the routing key must be numbers.")]
        [DataRow("V934@67", "The unique identifier must contain only letters and numbers.")]
        [DataRow("V93H456", "valid")]

        public void TestValidEircode(string eircode, string expected)
        {
            string result = MemberValidator.IsValidEircode(eircode);
            Assert.AreEqual(expected, result);
        }
    }
}
