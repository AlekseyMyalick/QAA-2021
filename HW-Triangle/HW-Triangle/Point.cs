using System;

namespace HW_Triangle
{
    public class Point
    {
        private int _x;
        private int _y;

        public Point (int x, int y) 
        {
            X = x;
            Y = y;
        }

        public int X
        {
            get
            {
                return _x;
            }
            set
            {
                CheckingCoordinates(value);
                _x = value;
            }
        }

        public int Y
        {
            get
            {
                return _y;
            }
            set
            {
                CheckingCoordinates(value);
                _y = value;
            }
        }

        public static double Distance(Point point1, Point point2)
        {
            return Math.Sqrt((point2.X - point1.X) * (point2.X - point1.X) + (point2.Y - point1.Y) * (point2.Y - point1.Y));
        }

        private void CheckingCoordinates(int coordinate)
        {
            if (coordinate < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
        }
    }
}
