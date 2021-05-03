using System;

namespace HW_Triangle.Triangles
{
    public abstract class Triangle
    {
        public Triangle(Point firstPoint, Point secondPoint, Point thirdPoint, Color color)
        {
            FirstPoint = firstPoint;
            SecondPoint = secondPoint;
            ThirdPoint = thirdPoint;
            Color = color;

            if (!IsThereATriangle())
            {
                throw new ArgumentException("A triangle with such sides cannot be created.", typeof(Triangle).Name);
            }
        }

        public Point FirstPoint { get; }

        public Point SecondPoint { get; }

        public Point ThirdPoint { get; }

        public Color Color { get; }

        public double CalculateArea()
        {
            return Math.Abs(FirstPoint.X * (SecondPoint.Y - ThirdPoint.Y) + 
                            SecondPoint.X * (ThirdPoint.Y - FirstPoint.Y) + 
                            ThirdPoint.X * (FirstPoint.Y - SecondPoint.Y)) / 2;
        }

        public virtual void InitializingTheSides(out double firstSide, out double secondSide, out double thirdSide)
        {
            firstSide = Point.Distance(FirstPoint, SecondPoint);
            secondSide = Point.Distance(FirstPoint, ThirdPoint);
            thirdSide = Point.Distance(SecondPoint, ThirdPoint);
        }

        private bool IsThereATriangle()
        {
            return CalculateArea() != 0;
        }

    }
}
