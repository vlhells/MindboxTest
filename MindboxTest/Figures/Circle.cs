using MindboxTest.Exceptions;
using MindboxTest.Interfaces;

namespace MindboxTest.Figures
{
    public class Circle: IFigure2D
    {
        private double Radius { get; set; }

        public Circle(double radius)
        {
            if (radius < 0)
            {
                throw new NegativeOrZeroValueException("Радиус не может принимать отрицательные значения.");
            }

            Radius = radius;
        }

        public double CalculateSquare()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
