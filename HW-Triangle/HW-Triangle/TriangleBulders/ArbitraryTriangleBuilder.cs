using System;
using HW_Triangle.Triangles;

namespace HW_Triangle.TriangleBulders
{
    class ArbitraryTriangleBuilder : TriangleBuilder
    {
        public override Triangle Build(Point firstPoint, Point secondPoint, Point thirdPoint)
        {
            try
            {
                return new ArbitraryTriangle(firstPoint, secondPoint, thirdPoint, Color.White);
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
