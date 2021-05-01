using HW_Triangle.Triangles;

namespace HW_Triangle.TriangleBulders
{
    class ArbitraryTriangleBuilder : TriangleBulder
    {
        public override Triangle Build(Point firstPoint, Point secondPoint, Point thirdPoint)
        {
            return new ArbitraryTriangle(firstPoint, secondPoint, thirdPoint);
        }

        public override Triangle TriangleBulderRequest(Point firstPoint, Point secondPoint, Point thirdPoint)
        {
            if (ArbitraryTriangle.IsThereArbitraryTriangle(firstPoint, secondPoint, thirdPoint))
            {
                return Build(firstPoint, secondPoint, thirdPoint);
            }
            else if (Successor != null)
            {
                return Successor.TriangleBulderRequest(firstPoint, secondPoint, thirdPoint);
            }
            else
            {
                return null;
            }
        }
    }
}
