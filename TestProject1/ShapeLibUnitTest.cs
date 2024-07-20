using ShapeLib.Exceptions;
using ShapeLib.Shapes;

namespace TestProject1
{
    [TestClass]
    public class ShapeLibUnitTest
    {
        [TestClass]
        public class CircleTests
        {
            // ���� �� ������������ ��������
            [TestMethod]
            public void TestResult()
            {
                Circle circle = new(radius: 2);

                double result = circle.GetSquare();
                double expected = 12.57;

                Assert.AreEqual(result, expected);
            }

            // ���� �� ����������� �������� �������� ������
            [TestMethod]
            [ExpectedException(typeof(ArgumentOutOfRangeException))]
            public void TestInitialData()
            {
                _ = new Circle(-2);
            }
        }

        [TestClass]
        public class TriangleTests()
        {
            // ���� �� ������������ ��������
            [TestMethod]
            public void TestResult()
            {
                Triangle triangle = new(5, 7, 9);

                double result = triangle.GetSquare();
                double expected = 17.41;

                Assert.AreEqual(result, expected);
            }

            // ���� �� ����������� �������� �������� ������
            [TestMethod]
            [ExpectedException(typeof(ArgumentOutOfRangeException))]
            public void TestInitialData()
            {
                _ = new Triangle(3, -5, 4);
            }

            // ���� �� ������������� ������������ 
            [TestMethod]
            [ExpectedException(typeof(ArgumentException))]
            public void CheckTriangleExists()
            {
                _ = new Triangle(4, 5, 10);
            }

            // ���� �� ������������� �����������
            [TestMethod]
            [ExpectedException(typeof(InvalidTriangleException))]
            public void TestRightTriangle()
            {
                _ = new Triangle(24, 26, 10);
            }
        }
    }
}