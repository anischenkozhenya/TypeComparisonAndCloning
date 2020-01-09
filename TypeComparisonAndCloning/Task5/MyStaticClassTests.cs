using NUnit.Framework;

namespace Task5
{
    [TestFixture]
    class MyStaticClassTests
    {
        [Test]
        public void SimpleTestWithManyWords()
        {
            Assert.AreEqual("battle no requires which that is victory greatest The", MyStaticClass.ReverseWords("The greatest victory is that which requires no battle"));
        }
        [Test]
        public void SimpleTestWithOneWord()
        {
            Assert.AreEqual("Battle", MyStaticClass.ReverseWords("Battle"));
        }
        [Test]
        public void EmptyString()
        {
            Assert.AreEqual("", MyStaticClass.ReverseWords(""));
        }
        [Test]
        public void ArgumentIsNull()
        {
            Assert.Throws<System.ArgumentNullException>(() => MyStaticClass.ReverseWords(null));
        }
    }
}
