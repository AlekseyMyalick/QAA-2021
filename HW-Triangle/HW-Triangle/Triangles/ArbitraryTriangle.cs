using System;

namespace HW_Triangle.Triangles
{
    class ArbitraryTriangle : Triangle, IFillable
    {
        private const string _color = "White";
        public ArbitraryTriangle(Point firstPoint, Point secondPoint, Point thirdPoint)
                    : base(firstPoint, secondPoint, thirdPoint) { }

        public new string Color => _color;

        public override double CalculateArea()
        {
            double P = (FirstSide + SecondSide + ThirdSide) / 2;

            return Math.Sqrt(P * (P - FirstSide) * (P - SecondSide) * (P - ThirdSide));
        }

        public static bool IsThereArbitraryTriangle(Point firstPoint, Point secondPoint, Point thirdPoint)
        {
            double firstSide = Point.Distance(firstPoint, secondPoint);
            double secondSide = Point.Distance(firstPoint, thirdPoint);
            double thirdSide = Point.Distance(secondPoint, thirdPoint);

            return firstSide + secondSide > thirdSide ||
                   secondSide + thirdSide > firstSide ||
                   thirdSide + firstSide > secondSide;
        }
    }
}
