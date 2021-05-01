namespace HW_Triangle.Triangles
{
    class RightTriangle : Triangle, IFillable
    {
        private const string _color = "Green";

        public RightTriangle(Point firstPoint, Point secondPoint, Point thirdPoint)
            : base(firstPoint, secondPoint, thirdPoint) { }

        public new string Color => _color;

        public override double CalculateArea()
        {
            HypotenuseSearch(out double a, out double b);

            return a * b / 2;
        }

        private void HypotenuseSearch(out double a, out double b)
        {
            if (FirstSide > SecondSide && FirstSide > ThirdSide)
            {
                a = SecondSide;
                b = ThirdSide;
            }
            else if (SecondSide > FirstSide && SecondSide > ThirdSide)
            {
                a = FirstSide;
                b = ThirdSide;
            }
            else
            {
                a = FirstSide;
                b = SecondSide;
            }
        }

        public static bool IsThereRightTriangle(Point firstPoint, Point secondPoint, Point thirdPoint)
        {
            double firstSide = Point.Distance(firstPoint, secondPoint);
            double secondSide = Point.Distance(firstPoint, thirdPoint);
            double thirdSide = Point.Distance(secondPoint, thirdPoint);

            return firstSide * firstSide + secondSide * secondSide == thirdSide * thirdSide ||
                   firstSide * firstSide + thirdSide * thirdSide == secondSide * secondSide ||
                   thirdSide * thirdSide + secondSide * secondSide == firstSide * firstSide;
        }
    }
}
