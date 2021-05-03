using System;

namespace HW_Triangle.Triangles
{
    class EquilateralTriangle : Triangle
    {
        public EquilateralTriangle(Point firstPoint, Point secondPoint, Point thirdPoint, Color color)
            : base(firstPoint, secondPoint, thirdPoint, color)
        {
            if (!IsThereEquilateralTriangle())
            {
                throw new ArgumentException("Equilateral triangle cannot be created");
            }
        }

        public bool IsThereEquilateralTriangle()
        {
            base.InitializingTheSides(out double firstSide, out double secondSide, out double thirdSide);

            return firstSide.CompareTo(secondSide) == 0 &&
                   secondSide.CompareTo(thirdSide) == 0;
        }
    }
}
