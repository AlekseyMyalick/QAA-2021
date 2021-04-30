using System;

namespace HW_Triangle.Triangles
{
    class IsoscelesTriangle : Triangle, IFillable
    {
        private const string _color = "Blue";

        public IsoscelesTriangle(Point firstPoint, Point secondPoint, Point thirdPoint)
            : base(firstPoint, secondPoint, thirdPoint) { }

        public string Color => _color;

        public override double CalculateArea()
        {
            SearchForEqualSides(out double a, out double b);

            return b * Math.Sqrt((a * a) - (b * b / 4)) / 2;
        }

        private void SearchForEqualSides(out double a, out double b)
        {
            if (firstSide == secondSide)
            {
                a = firstSide;
                b = thirdSide;
            }
            else if (secondSide == thirdSide)
            {
                a = secondSide;
                b = firstSide;
            }
            else
            {
                a = firstSide;
                b = secondSide;
            }
        }
    }
}
