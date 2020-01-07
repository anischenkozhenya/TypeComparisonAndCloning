using NUnit.Framework;

namespace Task3
{
    [TestFixture]
    class MyStaticClassTests
    {
        [Test]
        public void test1()
        {
            Assert.AreEqual("www.example.com?key=value", MyStaticClass.AddOrChangeUrlParameter("www.example.com", "key=value"));
            }
        [Test]
        public void test2()
        {
            Assert.AreEqual("www.example.com?key=value&key2=value2", MyStaticClass.AddOrChangeUrlParameter("www.example.com?key=value", "key2=value2"));
            }
        [Test]
        public void test3()
        {
            Assert.AreEqual("www.example.com?key=newValue", MyStaticClass.AddOrChangeUrlParameter("www.example.com?key=oldValue", "key=newValue"));
        }
    }
}
