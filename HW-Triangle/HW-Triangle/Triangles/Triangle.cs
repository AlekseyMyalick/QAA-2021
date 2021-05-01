using System;

namespace HW_Triangle.Triangles
{
    public abstract class Triangle
    {
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

        public double FirstSide { get; private set; }

        public double SecondSide { get; private set; }

        public double ThirdSide { get; private set; }

        public void InitializingTheSides()
        {
            FirstSide = Point.Distance(FirstPoint, SecondPoint);
            SecondSide = Point.Distance(FirstPoint, ThirdPoint);
            ThirdSide = Point.Distance(SecondPoint, ThirdPoint);
        }

        private bool IsThereATriangle()
        {
            return FirstSide + SecondSide > ThirdSide ||
                   SecondSide + ThirdSide > FirstSide ||
                   ThirdSide + FirstSide > SecondSide;
        }
    }
}
