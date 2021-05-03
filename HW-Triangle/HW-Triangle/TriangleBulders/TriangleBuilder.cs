using HW_Triangle.Triangles;

namespace HW_Triangle.TriangleBulders
{
    abstract class TriangleBuilder
    {
        public TriangleBuilder Successor { get; set; }

        public abstract Triangle Build(Point firstPoint, Point secondPoint, Point thirdPoint);
    }
}
