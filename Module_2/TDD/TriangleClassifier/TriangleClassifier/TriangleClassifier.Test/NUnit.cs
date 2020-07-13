using NUnit.Framework;
using TriangleClassifier.Service;
namespace TriangleClassifier.Test
{
    public class NUnit
    {
        private Triangle triangle;
        [SetUp]
        public void Setup()
        {
            triangle = new Triangle();
        }

        [Test]
        public void GetTriangle_1()
        {
            Assert.AreEqual("tam giác đều", triangle.GetTriangle(2,2,2));
        }
        [TestCase("tam giác đều")]
        public void GetTriangle_2(string value)
        {
            Assert.AreNotEqual(value, triangle.GetTriangle(3, 2, 3));
        }
        [TestCase("tam giác cân")]
        public void GetTriangle_3(string value)
        {
            Assert.IsTrue(value == triangle.GetTriangle(3, 2, 3));
        }
    }
}