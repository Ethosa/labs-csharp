using NUnit.Framework;

namespace TriangleTests
{
    public class Tests
    {
        [Test]
        public void TestEquilateral()
        {
            Assert.AreEqual("Equilateral", Triangle.GetTriangleType(3, 3, 3));
        }

        [Test]
        public void TestIsosceles()
        {
            Assert.AreEqual("Isosceles", Triangle.GetTriangleType(3, 3, 5));
        }

        [Test]
        public void TestRightTriangle()
        {
            Assert.AreEqual("Right", Triangle.GetTriangleType(3, 4, 5));
        }

        [Test]
        public void TestScalene()
        {
            Assert.AreEqual("Scalene", Triangle.GetTriangleType(3, 4, 6));
        }

        [Test]
        public void TestInvalid()
        {
            Assert.AreEqual("Invalid", Triangle.GetTriangleType(-1, 4, 5));
        }

        [Test]
        public void TestNotTriangle()
        {
            Assert.AreEqual("Not a Triangle", Triangle.GetTriangleType(1, 1, 3));
        }
    }
}
