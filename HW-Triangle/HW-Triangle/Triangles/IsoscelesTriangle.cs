using System;

namespace HW_Triangle.Triangles
{
    class IsoscelesTriangle : Triangle
    {
        public IsoscelesTriangle(Point firstPoint, Point secondPoint, Point thirdPoint, Color color)
            : base(firstPoint, secondPoint, thirdPoint, color)
        {
            if (!IsThereIsoscelesTriangle())
            {
                throw new ArgumentException("Isosceles triangle cannot be created");
            }
        }

        public bool IsThereIsoscelesTriangle()
        {
            base.InitializingTheSides(out double firstSide, out double secondSide, out double thirdSide);

            return firstSide.CompareTo(secondSide) == 0 ||
                   secondSide.CompareTo(thirdSide) == 0 ||
                   firstSide.CompareTo(thirdSide) == 0;
        }
    }
}
