using HW_Triangle.Triangles;

namespace HW_Triangle.TriangleBulders
{
    class ArbitraryTriangleBuilder : TriangleBulder
    {
        public override Triangle Build(Point firstPoint, Point secondPoint, Point thirdPoint)
        {
            return new ArbitraryTriangle(firstPoint, secondPoint, thirdPoint);
        }
    }
}
