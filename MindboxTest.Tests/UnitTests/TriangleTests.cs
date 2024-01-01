using MindboxTest.Exceptions;
using MindboxTest.Figures;

namespace UnitTests
{
    public class TriangleTests
    {
        [Fact]
        public void ConstructsTriangleWithPositiveSides()
        {
            // Arrange:

            var sideA = 4;
            var sideB = 2;
            var sideC = 3;

            // Act:

            var triangle = new Triangle(sideA, sideB, sideC);

            // Assert:

            Assert.IsAssignableFrom<Triangle>(triangle);
        }

        [Fact]
        public void GetExceptionConstructsTriangleWithNegativeAndZeroSides()
        {
            // Arrange:

            var sideA = -1;
            var sideB = 2;
            var sideC = 0;

            // Act & Assert:

            Assert.Throws<NegativeOrZeroValueException>(() => new Triangle(sideA, sideB, sideC));
        }

        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(2, 1, 3)]
        [InlineData(3, 2, 1)]
        public void GetExceptionConstructsTriangleWithImpossibleSidesValues(double sideA, double sideB, double sideC)
        {
            // Act & Assert:

            Assert.Throws<ImpossibleFormTriangleException>(() => new Triangle(sideA, sideB, sideC));
        }

        [Fact]
        public void CalculatesTriangleSquareCorrectly()
        {
            // Arrange:
            var sideA = 4;
            var sideB = 2;
            var sideC = 3;
            var triangle = new Triangle(sideA, sideB, sideC);
            var halfPerimeter = (sideA + sideB + sideC) / 2d;
            var expectedSquare = halfPerimeter * (halfPerimeter - sideA) * (halfPerimeter - sideB) * 
                (halfPerimeter - sideC);

            // Act:
            var actualSquare = triangle.CalculateSquare();

            // Assert:
            Assert.Equal(expectedSquare, actualSquare);
        }
    }
}