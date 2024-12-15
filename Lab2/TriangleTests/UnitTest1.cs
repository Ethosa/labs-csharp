using NUnit.Framework;

namespace TriangleTests
{
    public class Tests
    {
        [Test]
        public void TestEquilateral()
        {
            Assert.AreEqual("Равносторонний", Triangle.GetTriangleType(3, 3, 3));
        }

        [Test]
        public void TestIsosceles()
        {
            Assert.AreEqual("Равнобедренный", Triangle.GetTriangleType(3, 3, 5));
        }

        [Test]
        public void TestRightTriangle()
        {
            Assert.AreEqual("Правильный", Triangle.GetTriangleType(3, 4, 5));
        }

        [Test]
        public void TestScalene()
        {
            Assert.AreEqual("Разносторонний", Triangle.GetTriangleType(3, 4, 6));
        }

        [Test]
        public void TestInvalid()
        {
            Assert.AreEqual("Неправильный", Triangle.GetTriangleType(-1, 4, 5));
        }

        [Test]
        public void TestNotTriangle()
        {
            Assert.AreEqual("Не треугольник", Triangle.GetTriangleType(1, 1, 3));
        }
    }
}
