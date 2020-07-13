using NUnit.Framework;
using AbsoluteCalculator.Service;
using System;

namespace AbsoluteCalculator.Test
{
    public class AbsoluteNumberCalculatorTest
    {
        private AbsoluteNumberCalculator _absoluteNumberCalulator;

        [SetUp]
        public void Setup()
        {
            _absoluteNumberCalulator = new AbsoluteNumberCalculator();
        }

        [Test]
        public void TestFindAbsolute0()
        {
            int number = 0;
            int expected = 0;

            int result = _absoluteNumberCalulator.FindAbsolute(number);
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void TestFindAbsolute1()
        {
            int number = 1;
            int expected = 1;

            int result = _absoluteNumberCalulator.FindAbsolute(number);
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void TestFindAbsoluteNegative1()
        {
            int number = -1;
            int expected = 1;

            int result = _absoluteNumberCalulator.FindAbsolute(number);
            Assert.AreEqual(expected, result);
        }
        [TestCase(1)]
        [TestCase(-1)]
        public void TestFindAbsoluteList(int value)
        {
            Assert.IsTrue(1 == _absoluteNumberCalulator.FindAbsolute(value));
        }
    }
}