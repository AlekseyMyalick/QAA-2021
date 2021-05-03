using System;
using HW_Triangle.Triangles;

namespace HW_Triangle.TriangleBulders
{
    class EquilateralTriangleBuilder : TriangleBuilder
    {
        public override Triangle Build(Point firstPoint, Point secondPoint, Point thirdPoint)
        {
            try
            {
                return new EquilateralTriangle(firstPoint, secondPoint, thirdPoint, Color.Red);
            }
            catch (ArgumentException e)
            {
                if (e.ParamName == typeof(Triangle).Name)
                {
                    return null;
                }

                return Successor.Build(firstPoint, secondPoint, thirdPoint);
            }
        }
    }
}
