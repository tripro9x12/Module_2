using FizzBuzzTranslate.Service;
using NUnit.Framework;

namespace FizzBuzzTranslate.Test
{
    public class NUnit
    {
        private FizzBuzz fizzbuzz;
        [SetUp]
        public void Setup()
        {
            fizzbuzz = new FizzBuzz();
        }

        [Test]
        public void Translate_1()
        {
            Assert.AreEqual("Buzz", fizzbuzz.Translate(5));
        }
        [Test]
        public void Translate_2()
        {
            Assert.AreEqual("Fizz", fizzbuzz.Translate(3));
        }
        [Test]
        public void Translate_3()
        {
            Assert.AreEqual("FizzBuzz", fizzbuzz.Translate(15));
        }
        [Test]
        public void Translate_4()
        {
            Assert.IsTrue("hai sáu" == fizzbuzz.Translate(26));
        }
        [TestCase("bốn sáu")]
        public void Translate_5(string value)
        {
            Assert.IsTrue(value == fizzbuzz.Translate(46));
        }
    }
}