using HW_Triangle.TriangleBulders;
using System;

namespace HW_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                RightTriangleBuilder rightTriangleBuilder = new RightTriangleBuilder();
                EquilateralTriangleBuilder equilateralTriangleBuilder = new EquilateralTriangleBuilder();
                IsoscelesTriangleBuilder isoscelesTriangleBuilder = new IsoscelesTriangleBuilder();
                ArbitraryTriangleBuilder arbitraryTriangleBuilder = new ArbitraryTriangleBuilder();

                rightTriangleBuilder.Successor = equilateralTriangleBuilder;
                equilateralTriangleBuilder.Successor = isoscelesTriangleBuilder;
                isoscelesTriangleBuilder.Successor = arbitraryTriangleBuilder;

                Console.WriteLine(rightTriangleBuilder.Build(new Point(1, 1), new Point(2, 4), new Point(6, 1)).Color);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
