using NUnit.Framework;
using System;

namespace Task6
{
    [TestFixture]
    class MyStaticClassTests
    {
        [Test]
        public void StringWithNumbers()
        {
            Assert.AreEqual("10219", MyStaticClass.SumTwoBiggestNumbers("12 3  4 5 6 34 34  2354 234  654 23 4 234 324 6 7865"));
            Assert.AreEqual("12,4", MyStaticClass.SumTwoBiggestNumbers("1,1 9,2 3,2 "));
            Assert.AreEqual("11,2", MyStaticClass.SumTwoBiggestNumbers("1,3,2 9,2"));
            Assert.AreEqual("3353,2", MyStaticClass.SumTwoBiggestNumbers("1,3,2 999,2 12 3  4 5 6 34 34  2354"));
        }
        [Test]
        public void StringWithOneOrEmptyNumbers()
        {
            Assert.Throws<ArgumentException>(() => MyStaticClass.SumTwoBiggestNumbers("1234563442354234"));
            Assert.Throws<ArgumentException>(() => MyStaticClass.SumTwoBiggestNumbers("hjdsfkahjsdgfkjhs sdghfjshdgf dhas gshjdgf asdfjhg"));
        }
        [Test]
        public void StringNull()
        {
            Assert.Throws<ArgumentNullException>(() => MyStaticClass.SumTwoBiggestNumbers(null));
        }
    }
}
