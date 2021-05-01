using System;

namespace HW_Triangle.Triangles
{
    class EquilateralTriangle : Triangle, IFillable
    {
        private const string _color = "Red";

        public EquilateralTriangle(Point firstPoint, Point secondPoint, Point thirdPoint)
            : base(firstPoint, secondPoint, thirdPoint) { }

        public new string Color => _color;

        public override double CalculateArea()
        {
            return (FirstSide * FirstSide * Math.Sqrt(3)) / 4;
        }
        public static bool IsThereEquilateralTriangle(Point firstPoint, Point secondPoint, Point thirdPoint)
        {
            double firstSide = Point.Distance(firstPoint, secondPoint);
            double secondSide = Point.Distance(firstPoint, thirdPoint);
            double thirdSide = Point.Distance(secondPoint, thirdPoint);

            return firstSide == secondSide &&
                   secondSide == thirdSide;
        }
    }
}
