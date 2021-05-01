using HW_Triangle.Triangles;

namespace HW_Triangle.TriangleBulders
{
    class EquilateralTriangleBuilder : TriangleBulder
    {
        public override Triangle Build(Point firstPoint, Point secondPoint, Point thirdPoint)
        {
            return new EquilateralTriangle(firstPoint, secondPoint, thirdPoint);
        }

        public override Triangle TriangleBulderRequest(Point firstPoint, Point secondPoint, Point thirdPoint)
        {
            if (EquilateralTriangle.IsThereEquilateralTriangle(firstPoint, secondPoint, thirdPoint))
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
