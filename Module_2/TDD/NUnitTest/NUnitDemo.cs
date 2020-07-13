using NUnit.Framework;
using TDD;

namespace NUnitTest
{
    public class NUnitDemo       
    {
        private MyMath myMath;
        [SetUp]
        public void Setup()
        {
            myMath = new MyMath();
        }

        [Test]
        public void Add_1()
        {
            Assert.AreEqual(10,myMath.Add(3,7));
        }
        [TestCase(10)]
        [TestCase(0)]
        [TestCase(100)]
        public void Add_2(int value)
        {
            Assert.IsTrue(myMath.Add(value, 0) == value);
        }
    }
}