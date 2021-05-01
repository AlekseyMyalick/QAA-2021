using HW_Triangle.Triangles;

namespace HW_Triangle.TriangleBulders
{
    class IsoscelesTriangleBuilder : TriangleBulder
    {
        public override Triangle Build(Point firstPoint, Point secondPoint, Point thirdPoint)
        {
            return new IsoscelesTriangle(firstPoint, secondPoint, thirdPoint);
        }

        public override Triangle TriangleBulderRequest(Point firstPoint, Point secondPoint, Point thirdPoint)
        {
            if (IsoscelesTriangle.IsThereIsoscelesTriangle(firstPoint, secondPoint, thirdPoint))
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
