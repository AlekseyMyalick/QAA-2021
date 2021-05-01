using HW_Triangle.Triangles;

namespace HW_Triangle.TriangleBulders
{
    abstract class TriangleBulder
    {
        public TriangleBulder Successor { get; set; }

        public abstract Triangle Build(Point firstPoint, Point secondPoint, Point thirdPoint);

        public abstract Triangle TriangleBulderRequest(Point firstPoint, Point secondPoint, Point thirdPoint);
    }
}
