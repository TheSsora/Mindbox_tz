using AreaCalculator.Shapes;

namespace Shape.Tests
{
    [TestClass]
    public class TriangleTest
    {
        [TestMethod]
        public void CalculateArea_ThreeNumbers_ReturnArea()
        {
            // Arrange
            double sideA = 3;
            double sideB = 4;
            double sideC = 5;
            double expectedResult = 6;

            Triangle circle = new Triangle(sideA, sideB, sideC);

            // Act
            double result = Math.Round(circle.CalculateArea(),2);

            // Assert
            Assert.AreEqual(expectedResult, result);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CalculateArea_OneOrMoreZeroNumbers_ReturnException()
        {
            // Arrange
            double sideA = 0;
            double sideB = 4;
            double sideC = 5;

            Triangle circle = new Triangle(sideA, sideB, sideC);
        }
        [TestMethod]
        public void CalculateArea_RightTriangle_ReturnTrue()
        {
            // Arrange
            double sideA = 3;
            double sideB = 4;
            double sideC = 5;
            bool expectedResult = true;

            Triangle circle = new Triangle(sideA, sideB, sideC);

            // Act
            bool result = circle.IsRightTriangle;

            // Assert
            Assert.AreEqual(expectedResult, result);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CalculateArea_MaxSideLongerOrEqualSumOfOther_ReturnException()
        {
            // Arrange
            double sideA = 10;
            double sideB = 5;
            double sideC = 5;

            Triangle circle = new Triangle(sideA, sideB, sideC);
        }
    }
}