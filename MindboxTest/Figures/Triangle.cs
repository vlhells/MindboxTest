using MindboxTest.Exceptions;
using MindboxTest.Interfaces;

namespace MindboxTest.Figures
{
    public class Triangle : IFigure2D
    {
        private double SideA { get; set; }
        private double SideB { get; set; }
        private double SideC { get; set; }

        /// <summary>
        /// Checks if triangle is rectangular by given into constructor side values.
        /// </summary>
        public bool IsRectangular
        {
            get
            {
                if (SideA * SideA == SideB * SideB + SideC * SideC ||
                    SideB * SideB == SideA * SideA + SideC * SideC ||
                    SideC * SideC == SideA * SideA + SideB * SideB)
                {
                    return true;
                }
                return false;
            }
        }

        /// <summary>
        /// Forms a triangle to work if args are positive and triangle can be formed depends on side values. Else throw
        /// exceptions.
        /// </summary>
        /// <param name="sideA"></param>
        /// <param name="sideB"></param>
        /// <param name="sideC"></param>
        /// <exception cref="NegativeOrZeroValueException"></exception>
        /// <exception cref="ImpossibleFormTriangleException"></exception>
        public Triangle(double sideA, double sideB, double sideC)
        {
            if (!ArgsArePositive(sideA, sideB, sideC))
            {
                throw new NegativeOrZeroValueException("Один или несколько аргументов меньше либо равны нулю.");
            }
            if (!CanFormTriangle(sideA, sideB, sideC))
            {
                throw new ImpossibleFormTriangleException("По заданным сторонам невозможно построить треугольник.");
            }

            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        /// <summary>
        /// Calculates triangle square by Heron's formula (by 3 sides).
        /// </summary>
        /// <returns>Triangle square value.</returns>
        public double CalculateSquare()
        {
            var halfPerimeter = (SideA + SideB + SideC) / 2;

            return halfPerimeter * (halfPerimeter - SideA) * (halfPerimeter - SideB) * (halfPerimeter - SideC);
        }

        private bool ArgsArePositive(double sideA, double sideB, double sideC) =>
            sideA > 0 && sideB > 0 && sideC > 0;

        private bool CanFormTriangle(double sideA, double sideB, double sideC)
            => sideA + sideB > sideC && sideA + sideC > sideB && sideB + sideC > sideA;
    }
}
