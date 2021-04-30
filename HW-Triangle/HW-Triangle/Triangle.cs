using System;

namespace HW_Triangle
{
    public abstract class Triangle
    {
        public Triangle(Point firstPoint, Point secondPoint, Point thirdPoint)
        {
            FirstPoint = firstPoint;
            SecondPoint = secondPoint;
            ThirdPoint = thirdPoint;

            IsThereATriangle();
        }

        public Point FirstPoint { get; }
        public Point SecondPoint { get; }
        public Point ThirdPoint { get; }

        private void IsThereATriangle()
        {
            double firstSide = Point.Distance(FirstPoint, SecondPoint);
            double secondSide = Point.Distance(FirstPoint, ThirdPoint);
            double thirdSide = Point.Distance(SecondPoint, ThirdPoint);

            if (firstSide == 0 || secondSide == 0 || thirdSide == 0)
            {
                throw new ArgumentException("A triangle with such sides cannot be created.");
            } 

            if (firstSide + secondSide > thirdSide &&
                secondSide + thirdSide > firstSide &&
                thirdSide + firstSide > secondSide)
            {
                throw new ArgumentException("A triangle with such sides cannot be created.");
            }
        }

        public abstract double CalculateArea();
    }
}
