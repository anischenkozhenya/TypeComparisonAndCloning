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
            Assert.AreEqual("www.example.com?key=newValue1", MyStaticClass.AddOrChangeUrlParameter("www.example.com?key=oldValue", "key=newValue1"));
        }
        [Test]
        public void test4()
        {
            Assert.AreEqual("www.example.com", MyStaticClass.AddOrChangeUrlParameter("www.example.com?", ""));
        }
        [Test]
        public void test5()
        {
            Assert.Throws<System.ArgumentNullException>(() => MyStaticClass.AddOrChangeUrlParameter("", null));
            Assert.Throws<System.ArgumentNullException>(() => MyStaticClass.AddOrChangeUrlParameter(null, ""));
            Assert.Throws<System.ArgumentNullException>(() => MyStaticClass.AddOrChangeUrlParameter(null, null));
        }
    }
}
