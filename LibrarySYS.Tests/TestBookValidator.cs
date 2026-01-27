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
        [DataRow("978-3-16-148410-0", true)]
        [DataRow("9783161484100", true)]
        [DataRow("123-4-56-789012-3", false)]
        [DataRow("978-3-16-148410-X", false)]
        [DataRow("974-3-16-148410-X", false)]
        [DataRow("    ", false)]
        [DataRow(null, false)]
        public void TestValidISBN(string isbn, bool expected)
        {
            bool result = BookValidator.IsValidISBN(isbn);
            Assert.AreEqual(expected, result);
        }
    }
}
