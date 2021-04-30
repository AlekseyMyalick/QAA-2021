using System;

namespace HW_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            RightTriangle rightTriangle = new RightTriangle(new Point(2, 1), new Point(2, 5), new Point(4, 1));
            EquilateralTriangle equilateralTriangle = new EquilateralTriangle(new Point(1, 1), new Point(5, 9), new Point(9, 1));
            IsoscelesTriangle isoscelesTriangle = new IsoscelesTriangle(new Point(1, 1), new Point(3, 5), new Point(5, 1));
            ArbitraryTriangle triangle = new ArbitraryTriangle(new Point(1, 1), new Point(2, 4), new Point(6, 1));

            IFillable[] triangles = new IFillable[] { rightTriangle, equilateralTriangle, isoscelesTriangle, triangle };

            foreach (IFillable item in triangles)
            {
                Console.WriteLine("Color = " + item.Color);
                Console.WriteLine("");
            }
        }
    }
}
