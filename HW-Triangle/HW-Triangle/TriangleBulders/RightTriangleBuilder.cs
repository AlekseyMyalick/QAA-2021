using HW_Triangle.Triangles;

namespace HW_Triangle.TriangleBulders
{
    class RightTriangleBuilder : TriangleBulder
    {
        public override Triangle Build(Point firstPoint, Point secondPoint, Point thirdPoint)
        {
            return new RightTriangle(firstPoint, secondPoint, thirdPoint);
        }

        public override Triangle TriangleBulderRequest(Point firstPoint, Point secondPoint, Point thirdPoint)
        {
            if (RightTriangle.IsThereRightTriangle(firstPoint, secondPoint, thirdPoint))
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
