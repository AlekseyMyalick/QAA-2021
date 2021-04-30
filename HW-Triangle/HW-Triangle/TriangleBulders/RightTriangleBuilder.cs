using HW_Triangle.Triangles;

namespace HW_Triangle.TriangleBulders
{
    class RightTriangleBuilder : TriangleBulder
    {
        public override Triangle Build(Point firstPoint, Point secondPoint, Point thirdPoint)
        {
            return new RightTriangle(firstPoint, secondPoint, thirdPoint);
        }
    }
}
