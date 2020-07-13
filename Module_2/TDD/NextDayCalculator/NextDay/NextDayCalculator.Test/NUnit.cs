using NextDayCalculator.Service;
using NUnit.Framework;

namespace NextDayCalculator.Test
{
    public class NUnit
    {
        private NextDay nextday;
        [SetUp]
        public void Setup()
        {
            nextday = new NextDay();
        }

        [Test]
        public void GetDay_1()
        {
            Assert.AreEqual("3/1/1998", nextday.GetDateTime(2, 1, 1998));
            
        }
        [Test]
        public void GetDay_2()
        {
            Assert.AreEqual("1/3/2000", nextday.GetDateTime(29, 2, 2000));
        }
        [Test]
        public void GetDay_3()
        {
            Assert.AreNotEqual("1/1/2001", nextday.GetDateTime(1, 1, 2001));
        }
        [Test]
        public void GetDay_4()
        {
            Assert.AreEqual("1/1/2001", nextday.GetDateTime(31, 12, 2000));
        }
    }
}