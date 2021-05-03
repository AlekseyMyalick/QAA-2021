using System;

namespace HW_Triangle.Triangles
{
    class ArbitraryTriangle : Triangle
    {
        public ArbitraryTriangle(Point firstPoint, Point secondPoint, Point thirdPoint, Color color)
                    : base(firstPoint, secondPoint, thirdPoint, color)
        {
            if (!IsThereArbitraryTriangle())
            {
                throw new ArgumentException("Arbitrary triangle cannot be created");
            }
        }

        public bool IsThereArbitraryTriangle()
        {
            base.InitializingTheSides(out double firstSide, out double secondSide, out double thirdSide);

            return thirdSide.CompareTo(firstSide + secondSide) < 0 ||
                   firstSide.CompareTo(secondSide + thirdSide) < 0 ||
                   secondSide.CompareTo(thirdSide + firstSide) < 0;
        }
    }
}
