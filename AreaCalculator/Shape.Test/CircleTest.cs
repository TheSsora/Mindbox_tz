using AreaCalculator.Shapes;

namespace Shape.Tests
{
    [TestClass]
    public class CircleTest
    {
        [TestMethod]
        public void CalculateArea_Radius_ReturnArea()
        {
            // Arrange
            double radius = 2;
            double expectedResult = 12.57;

            Circle circle = new Circle(radius);

            // Act
            double result = Math.Round(circle.CalculateArea(),2);

            // Assert
            Assert.AreEqual(expectedResult, result);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CalculateArea_RadiusEqualZero_ReturnException()
        {
            // Arrange
            double radius = 0;

            Circle circle = new Circle(radius);
        }
    }
}