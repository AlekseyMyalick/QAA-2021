using System;
using HW_Triangle.Triangles;

namespace HW_Triangle.TriangleBulders
{
    class IsoscelesTriangleBuilder : TriangleBuilder
    {
        public override Triangle Build(Point firstPoint, Point secondPoint, Point thirdPoint)
        {
            try
            {
                return new IsoscelesTriangle(firstPoint, secondPoint, thirdPoint, Color.Blue);
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
