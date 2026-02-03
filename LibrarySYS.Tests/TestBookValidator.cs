namespace LibrarySYS.Tests
{
    [TestClass]
    public class TestBookValidator
    {
        [DataTestMethod]
        [DataRow("The Maze Runner", true)]
        [DataRow(null, false)]
        [DataRow("", false)]
        [DataRow("    ", false)]
        [DataRow("Harry Potter & the Goblet of Fire", false)]
        [DataRow("A very very very very very long title that fails", false)]
        public void TestValidTitle(string title, bool expected)
        {
            bool result = BookValidator.IsValidTitle(title);
            Assert.AreEqual(expected, result);
        }

        [DataTestMethod]
        [DataRow("J.K. Rowling", true)]
        [DataRow(null, false)]
        [DataRow("", false)]
        [DataRow("    ", false)]
        [DataRow("An Author With An Exceptionally Long Name Exceeding Limits", false)]
        public void TestValidAuthor(string author, bool expected)
        {
            bool result = BookValidator.IsValidAuthor(author);
            Assert.AreEqual(expected, result);
        }

        [DataTestMethod]
        [DataRow("A thrilling dystopian novel", true)]
        [DataRow("A thrilling dystopain novel set in the late 1800s", false)]
        [DataRow("", false)]
        [DataRow("    ", false)]
        [DataRow(null, false)]
        public void TestValidDescription(string description, bool expected)
        {
            bool result = BookValidator.IsValidDescription(description);
            Assert.AreEqual(expected, result);
        }

        [DataTestMethod]
        [DataRow(null, "ISBN must not be null or contain only whitespaces")]
        [DataRow("", "ISBN must not be null or contain only whitespaces")]
        [DataRow("   ", "ISBN must not be null or contain only whitespaces")]

        // Invalid characters
        [DataRow("978-3-16-14841X-0", "ISBN must only contain numbers and dashes")]
        [DataRow("978-3-16-14@410-0", "ISBN must only contain numbers and dashes")]

        // Hyphen placement
        [DataRow("9783161484100", "ISBN must contain 5 sections")]
        [DataRow("978-3-16-148-41-0", "ISBN must contain 5 sections")]

        // Prefix
        [DataRow("977-3-16-148410-0", "ISBN must begin with '978' or '979'")]
        [DataRow("980-3-16-148410-0", "ISBN must begin with '978' or '979'")]

        // Component lengths
        [DataRow("978--167-148410-0", "Registration Group should be of length 1-5")]
        [DataRow("978-123456-1-10-0", "Registration Group should be of length 1-5")]

        [DataRow("978-3--148410-0", "Registrant should be of length 1-7")]
        [DataRow("978-3-12345678-148410-0", "Registrant should be of length 1-7")]

        [DataRow("978-63256-1769--0", "Publication should be of length 1-7")]
        [DataRow("978-3-6-12345678-0", "Publication should be of length 1-7")]

        [DataRow("978-3-16-148410-0", "Valid ISBN")]
        [DataRow("978-3-16-148410-1", "Invalid Check Digit")]

        // Valid ISBN
        [DataRow("978-0-306-40615-7", "Valid ISBN")]
        public void TestValidISBN(string isbn, string expected)
        {
            string result = BookValidator.IsValidISBN(isbn);
            Assert.AreEqual(expected, result);
        }

        [DataTestMethod]
        [DataRow("978-0-306-40615-8", false)]
        [DataRow("978-0-306-40615-7", true)]
        public void TestValidCheckDigit(string isbn, bool expected)
        {
            bool result = BookValidator.IsValidCheckDigit(isbn);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestIsUniqueISBN_ReturnsTrue_WhenISBNDoesNotExist()
        {
            string isbn = "999-9-99-999999-9";
            bool result = BookValidator.IsUniqueISBN(isbn);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestIsUniqueISBN_ReturnsTrue_WhenISBNDoesExist()
        {
            string isbn = "978-0-385-73794-4";
            bool result = BookValidator.IsUniqueISBN(isbn);
            Assert.IsTrue(result);
        }

        [DataTestMethod]
        [DataRow("", false)]
        [DataRow("    ", false)]
        [DataRow(null, false)]
        public void TestValidGenre(string genre, bool expected)
        {
            bool result = BookValidator.IsValidGenre(genre);
            Assert.AreEqual(expected, result);
        }

        [DataTestMethod]
        [DataRow("3000-01-01", false)]
        [DataRow("2005-06-12", true)]
        public void TestValidPublicationDate(string publication, bool expected)
        {
            DateTime publicationDate = DateTime.Parse(publication);
            bool result = BookValidator.IsValidPublicationDate(publicationDate);
            Assert.AreEqual(expected, result);
        }
    }
}
