using HW_Triangle.Triangles;

namespace HW_Triangle.TriangleBulders
{
    abstract class TriangleBulder
    {
        public abstract Triangle Build(Point firstPoint, Point secondPoint, Point thirdPoint);
    }
}
