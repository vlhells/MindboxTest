using MindboxTest.Exceptions;
using MindboxTest.Figures;

namespace UnitTests
{
    public class CircleTests
    {
        [Fact]
        public void ConstructsCircleWithCommonRadius()
        {
            // Arrange:
            double radius = 1;

            // Act:

            var circle = new Circle(radius);

            // Assert:
            Assert.IsAssignableFrom<Circle>(circle);
        }

        [Fact]
        public void GetExceptionConstructsCircleWithNegativeRadiusFails()
        {
            // Arrange:
            double radius = -1;

            // Act & Assert:
            Assert.Throws<NegativeOrZeroValueException>(() => new Circle(radius));
        }

        [Fact]
        public void CalculatesCircleSquareCorrectly()
        {
            // Arrange:
            double radius = 1;
            var circle = new Circle(radius);
            var expectedSquare = Math.PI * radius * radius;

            // Act:
            var actualSquare = circle.CalculateSquare();

            // Assert:
            Assert.Equal(expectedSquare, actualSquare);
        }
    }
}
