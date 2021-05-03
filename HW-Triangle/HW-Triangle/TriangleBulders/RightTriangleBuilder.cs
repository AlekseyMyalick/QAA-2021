using System;
using HW_Triangle.Triangles;

namespace HW_Triangle.TriangleBulders
{
    class RightTriangleBuilder : TriangleBuilder
    {
        public override Triangle Build(Point firstPoint, Point secondPoint, Point thirdPoint)
        {
            try
            {
                return new RightTriangle(firstPoint, secondPoint, thirdPoint, Color.Green);
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
