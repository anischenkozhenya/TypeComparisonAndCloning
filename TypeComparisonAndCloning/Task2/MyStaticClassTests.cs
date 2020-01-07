using NUnit.Framework;
namespace Task2
{
    [TestFixture]
    class MyStaticClassTests
    {
        [Test]
        public void NotNullOriginStringAndListMinorWords()
        {
            Assert.AreEqual("A Clash of Kings", MyStaticClass.TitleCase("a clash of KINGS", "a an the of"));
            Assert.AreEqual("The Wind in the Willows", MyStaticClass.TitleCase("THE WIND IN THE WILLOWS", "The In"));
        }
        [Test]
        public void OneWordOriginStringAndListMinorWords()
        {
            Assert.AreEqual("Kings", MyStaticClass.TitleCase("KINGS", "a an the of"));
            Assert.AreEqual("Kings", MyStaticClass.TitleCase("KINGS", "a an the of KINGS"));
        }
        [Test]
        public void OriginStringAndListOneWordMinorWords()
        {
            Assert.AreEqual("The Wind in The Willows", MyStaticClass.TitleCase("THE WIND IN THE WILLOWS", "In"));
            Assert.AreEqual("In The Willows", MyStaticClass.TitleCase("IN THE WILLOWS", "in"));
        }
        [Test]
        public void NullOrEmptyOriginString()
        {
            Assert.AreEqual("", MyStaticClass.TitleCase("", "a an the of"));
            Assert.Throws<System.ArgumentNullException>(() => MyStaticClass.TitleCase(null, "The In"));
        }
        [Test]
        public void NotNullOriginStringAndNullOrEmptyListMinorWords()
        {
            Assert.AreEqual("The Quick Brown Fox", MyStaticClass.TitleCase("the quick brown fox"));
            Assert.Throws<System.ArgumentNullException>(() => MyStaticClass.TitleCase("the quick brown fox", null));
        }
    }
}
