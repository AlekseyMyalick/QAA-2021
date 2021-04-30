using System;

namespace HW_Triangle.Triangles
{
    class EquilateralTriangle : Triangle, IFillable
    {
        private const string _color = "Red";

        public EquilateralTriangle(Point firstPoint, Point secondPoint, Point thirdPoint)
            : base(firstPoint, secondPoint, thirdPoint) { }

        public string Color => _color;

        public override double CalculateArea()
        {
            return (firstSide * firstSide * Math.Sqrt(3)) / 4;
        }
    }
}
