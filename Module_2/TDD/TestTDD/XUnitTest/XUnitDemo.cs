using System;
using TDD;
using Xunit;
using XUnitTest;

namespace XUnitTest
{
    public class XUnitDemo
    {
        private MyMath mymath;
        public XUnitDemo()
        {
            mymath = new MyMath();
        }

        [Fact]
        public void Hieu1()
        {
            Assert.Equal(2, mymath.Hieu(7, 5));
        }
        [Theory]
        [InlineData(1)]
        [InlineData(0)]
        [InlineData(10)]
        public void Hieu_2(int value)
        {
            Assert.True(mymath.Hieu(value, 0) == value);
        }

        [Theory]
        [InlineData(1)]
        [InlineData(0)]
        [InlineData(10)]
        public void Hieu_3(int value)
        {
            Assert.NotEqual(value,mymath.Hieu(value,2));
        }
    }
}
