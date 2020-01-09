using NUnit.Framework;
using System.Collections.Generic;

namespace Task4
{
    [TestFixture]
    class MyStaticClassTests
    {
        [Test]
        public void test1()
        {
            Assert.AreEqual("abcdb", MyStaticClass.UniqueInOrder("abbbbcddb"));
            Assert.AreEqual("ABCDAB", MyStaticClass.UniqueInOrder("AAAABBBCCDAABBB"));
            Assert.AreEqual("ABCcAD", MyStaticClass.UniqueInOrder("ABBCcAD"));
            Assert.AreEqual("123", MyStaticClass.UniqueInOrder("12233"));
        }
        [Test]
        public void test2()
        {
            Assert.AreEqual(new List<string>() {"a","b","c","d",""}, MyStaticClass.UniqueInOrder<string>(new List<string>{"a", "b","b","b", "c", "c", "c", "d","",""}));
            Assert.AreEqual(new List<int>() {1,2,3,4,5,4,2 }, MyStaticClass.UniqueInOrder<int>(new List<int>(){1,1,2,3,3,3,4,4,4,4,5,4,4,2,2,2}));
            Assert.AreEqual(new List<double> { 1.1, 2.2, 3.3 }, MyStaticClass.UniqueInOrder(new List<double> { 1.1, 2.2, 2.2, 3.3 })); 

        }

    }
}
