using ISBNc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Xunit;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace unitTest
{
    [TestClass]
    public class UnitTest1
    {
        [Fact]
        public void ValidarISBNF10()
        {
            ISBN_validator obj = new ISBN_validator();

            string isbn = "1566199093";

            bool result = obj.VISBN10(isbn);

            Assert.IsTrue(result);

        }
        [Fact]
        public void invalidarISBNF10()
        {
            ISBN_validator obj = new ISBN_validator();

            string isbn = "15661990";

            bool result = obj.VISBN10(isbn);

            Assert.IsFalse(result);
        }
        [Fact]
        public void ValidarISBNF13()
        {
            ISBN_validator obj = new ISBN_validator();

            string isbn = "9781566199094";

            bool result = obj.VISBN13(isbn);

            Assert.IsTrue(result);

        }
        [Fact]
        public void invalidarISBNF13()
        {
            ISBN_validator obj = new ISBN_validator();

            string isbn = "97815661994";

            bool result = obj.VISBN13(isbn);

            Assert.IsFalse(result);

        }
    }

}