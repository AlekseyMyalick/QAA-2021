using System;

namespace Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int size = 5;
                SquareMatrix squareMatrix = new SquareMatrix(size);
                squareMatrix.RandomMatrixInitialization(0, 10);
                Console.WriteLine(squareMatrix.ToString());
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
