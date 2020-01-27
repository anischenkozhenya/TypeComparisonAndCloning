using NUnit.Framework;

namespace Task1
{
    [TestFixture]
    class CustomerClassTests
    {
        [Test]
        public void FullInformation()
        {
            var instanse = new CustomerClass();
            instanse.Name = "Jeffrey Richter";
            instanse.Revenue = 1000000;
            instanse.ContactPhone = "+1 (425) 555-0100";

            string actual = instanse.GetFullInformation();
            string expected = "Jeffrey Richter, 1,000,000.00, +1 (425) 555-0100";
            
            Assert.AreEqual(expected,actual);
        }
        [Test]
        public void OnlyPhone()
        {
            var instanse = new CustomerClass();
            instanse.ContactPhone = "+1 (425) 555-0100";

            string actual = instanse.GetPhone();
            string expected = "+1 (425) 555-0100";

            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void OnlyName()
        {
            var instanse = new CustomerClass();
            instanse.Name = "Jeffrey Richter";

            string actual = instanse.GetName();
            string expected = "Jeffrey Richter";

            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void NameAndRevenue()
        {
            var instanse = new CustomerClass();
            instanse.Name = "Jeffrey Richter";
            instanse.Revenue = 1000000;

            string actual = instanse.GetNameAndRevenue();
            string expected = "Jeffrey Richter, 1,000,000.00";

            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void Revenue()
        {
            var instanse = new CustomerClass();
            instanse.Revenue = 1000000;

            string actual = instanse.GetOnlyRevenue();
            string expected = "1,000,000.00";

            Assert.AreEqual(expected, actual);
        }
    }
}
