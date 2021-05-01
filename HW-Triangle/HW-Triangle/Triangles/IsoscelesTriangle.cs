using System;

namespace HW_Triangle.Triangles
{
    class IsoscelesTriangle : Triangle, IFillable, ICalculatedArea
    {
        private const string _color = "Blue";

        public IsoscelesTriangle(Point firstPoint, Point secondPoint, Point thirdPoint)
            : base(firstPoint, secondPoint, thirdPoint) { }

        public string Color => _color;

        public double CalculateArea()
        {
            SearchForEqualSides(out double a, out double b);

            return b * Math.Sqrt((a * a) - (b * b / 4)) / 2;
        }

        private void SearchForEqualSides(out double a, out double b)
        {
            if (FirstSide == SecondSide)
            {
                a = FirstSide;
                b = ThirdSide;
            }
            else if (SecondSide == ThirdSide)
            {
                a = SecondSide;
                b = FirstSide;
            }
            else
            {
                a = FirstSide;
                b = SecondSide;
            }
        }

        public static bool IsThereIsoscelesTriangle(Point firstPoint, Point secondPoint, Point thirdPoint)
        {
            double firstSide = Point.Distance(firstPoint, secondPoint);
            double secondSide = Point.Distance(firstPoint, thirdPoint);
            double thirdSide = Point.Distance(secondPoint, thirdPoint);

            return firstSide == secondSide ||
                   secondSide == thirdSide ||
                   firstSide == thirdSide;
        }
    }
}
