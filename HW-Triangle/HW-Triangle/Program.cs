using System;

namespace HW_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(1, 1);
            Point p2 = new Point(10, 10);

            Console.WriteLine(Point.Distance(p1, p2));
        }
    }
}
