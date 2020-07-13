using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDD;

namespace MStest
{
    [TestClass]
    public class MStestDemo
    {
        private MyMath MyMath;
        [TestMethod]
        public void Multiply_1()
        {
            MyMath = new MyMath();
            Assert.IsTrue(100 == MyMath.Multiply(10, 10));
        }
    }
}
