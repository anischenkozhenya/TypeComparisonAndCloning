using NUnit.Framework;

namespace Task3
{
    [TestFixture]
    class MyStaticClassTests
    {
        [Test]
        public void AddNewParameterToUrlWithoutParameter()
        {
            Assert.AreEqual("www.example.com?key=value", MyStaticClass.AddOrChangeUrlParameter("www.example.com", "key=value"));
        }
        [Test]
        public void AddNewParameterToUrlWithParameter()
        {
            Assert.AreEqual("www.example.com?key=value&key2=value2", MyStaticClass.AddOrChangeUrlParameter("www.example.com?key=value", "key2=value2"));
        }
        [Test]
        public void ChangeOldValueInUrlOnNewValueFromParameterWithSameKey()
        {
            Assert.AreEqual("www.example.com?key=newValue", MyStaticClass.AddOrChangeUrlParameter("www.example.com?key=oldValue", "key=newValue"));
            Assert.AreEqual("www.example.com?key=newValue&key2=oldValue2", MyStaticClass.AddOrChangeUrlParameter("www.example.com?key=oldValue&key2=oldValue2", "key=newValue"));
            Assert.AreEqual("www.example.com?key=oldValue&key2=newValue2", MyStaticClass.AddOrChangeUrlParameter("www.example.com?key=oldValue&key2=oldValue2", "key2=newValue2"));
            Assert.AreEqual("www.example.com?key=newValue&key2=newValue2", MyStaticClass.AddOrChangeUrlParameter("www.example.com?key=oldValue&key2=oldValue2", "key=newValue&key2=newValue2"));
        }
        [Test]
        public void AddEmptyParameter()
        {
            Assert.AreEqual("www.example.com", MyStaticClass.AddOrChangeUrlParameter("www.example.com?", ""));
        }
        [Test]
        public void NullArguments()
        {
            Assert.Throws<System.ArgumentNullException>(() => MyStaticClass.AddOrChangeUrlParameter("", null));
            Assert.Throws<System.ArgumentNullException>(() => MyStaticClass.AddOrChangeUrlParameter(null, ""));
            Assert.Throws<System.ArgumentNullException>(() => MyStaticClass.AddOrChangeUrlParameter(null, null));
        }
    }
}
