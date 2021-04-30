namespace HW_Triangle.Triangles
{
    class RightTriangle : Triangle, IFillable
    {
        private const string _color = "Green";

        public RightTriangle(Point firstPoint, Point secondPoint, Point thirdPoint)
            : base(firstPoint, secondPoint, thirdPoint) { }

        public string Color => _color;

        public override double CalculateArea()
        {
            HypotenuseSearch(out double a, out double b);

            return a * b / 2;
        }

        private void HypotenuseSearch(out double a, out double b)
        {
            if (firstSide > secondSide && firstSide > thirdSide)
            {
                a = secondSide;
                b = thirdSide;
            }
            else if (secondSide > firstSide && secondSide > thirdSide)
            {
                a = firstSide;
                b = thirdSide;
            }
            else
            {
                a = firstSide;
                b = secondSide;
            }
        }
    }
}
