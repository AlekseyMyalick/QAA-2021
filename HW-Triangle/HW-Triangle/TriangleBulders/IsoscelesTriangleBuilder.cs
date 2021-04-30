using HW_Triangle.Triangles;

namespace HW_Triangle.TriangleBulders
{
    class IsoscelesTriangleBuilder : TriangleBulder
    {
        public override Triangle Build(Point firstPoint, Point secondPoint, Point thirdPoint)
        {
            return new IsoscelesTriangle(firstPoint, secondPoint, thirdPoint);
        }
    }
}
