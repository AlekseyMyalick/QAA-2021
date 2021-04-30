using HW_Triangle.Triangles;

namespace HW_Triangle.TriangleBulders
{
    class EquilateralTriangleBuilder : TriangleBulder
    {
        public override Triangle Build(Point firstPoint, Point secondPoint, Point thirdPoint)
        {
            return new EquilateralTriangle(firstPoint, secondPoint, thirdPoint);
        }
    }
}
