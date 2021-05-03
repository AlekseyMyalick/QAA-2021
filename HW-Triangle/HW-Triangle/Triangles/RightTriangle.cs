using System;

namespace HW_Triangle.Triangles
{
    class RightTriangle : Triangle
    {
        public RightTriangle(Point firstPoint, Point secondPoint, Point thirdPoint, Color color)
            : base(firstPoint, secondPoint, thirdPoint, color)
        {
            if (!IsThereRightTriangle())
            {
                throw new ArgumentException("Right triangle cannot be created");
            }
        }

        public bool IsThereRightTriangle()
        {
            base.InitializingTheSides(out double firstSide, out double secondSide, out double thirdSide);

            return (thirdSide * thirdSide).CompareTo(firstSide * firstSide + secondSide * secondSide) == 0 ||
                   (secondSide * secondSide).CompareTo(firstSide * firstSide + thirdSide * thirdSide) == 0 ||
                   (firstSide * firstSide).CompareTo(thirdSide * thirdSide + secondSide * secondSide) == 0;
        }
    }
}
