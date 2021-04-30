using System;

namespace HW_Triangle
{
    public class Triangle
    {
        protected double firstSide;
        protected double secondSide;
        protected double thirdSide;

        public Triangle(Point firstPoint, Point secondPoint, Point thirdPoint)
        {
            FirstPoint = firstPoint;
            SecondPoint = secondPoint;
            ThirdPoint = thirdPoint;

            InitializingTheSides();

            if (!IsThereATriangle())
            {
                throw new ArgumentException("A triangle with such sides cannot be created.");
            }
        }

        public Point FirstPoint { get; }
        public Point SecondPoint { get; }
        public Point ThirdPoint { get; }

        private void InitializingTheSides()
        {
            firstSide = Point.Distance(FirstPoint, SecondPoint);
            secondSide = Point.Distance(FirstPoint, ThirdPoint);
            thirdSide = Point.Distance(SecondPoint, ThirdPoint);
        }

        private bool IsThereATriangle()
        {
            return firstSide + secondSide > thirdSide &&
                   secondSide + thirdSide > firstSide &&
                   thirdSide + firstSide > secondSide;
        }

        public virtual double CalculateArea()
        {
            double P = (firstSide + secondSide + thirdSide) / 2;

            return Math.Sqrt(P * (P - firstSide) * (P - secondSide) * (P - thirdSide));
        }
    }
}
