using System;

namespace HW_Triangle.Triangles
{
    class ArbitraryTriangle : Triangle, IFillable
    {
        private const string _color = "White";
        public ArbitraryTriangle(Point firstPoint, Point secondPoint, Point thirdPoint)
                    : base(firstPoint, secondPoint, thirdPoint) { }

        public string Color => _color;

        public override double CalculateArea()
        {
            double P = (firstSide + secondSide + thirdSide) / 2;

            return Math.Sqrt(P * (P - firstSide) * (P - secondSide) * (P - thirdSide));
        }
    }
}
