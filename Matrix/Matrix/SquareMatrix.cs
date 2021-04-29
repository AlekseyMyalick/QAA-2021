using System;
using System.Text;

namespace Matrix
{
    class SquareMatrix
    {
        public int Size { get; }
        protected int[] matrix;

        public SquareMatrix(int size)
        {
            Size = size;
            matrix = new int[Size * Size];
        }

        public void RandomMatrixInitialization(int minValue, int maxValue)
        {
            Random random = new Random();

            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    this[i, j] = random.Next(minValue, maxValue);
                }
            }
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();

            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    builder.Append(this[i, j]);
                    builder.Append("\t");
                }
                builder.Append("\n");
            }

            return builder.ToString();
        }

        public virtual int this[int i, int j]
        {
            get
            {
                CheckingMatrixIndices(i, j);
                return matrix[i * Size + j];
            }
            set
            {
                CheckingMatrixIndices(i, j);
                matrix[i * Size + j] = value;
            }
        }

        public virtual void CheckingMatrixIndices(int i, int j)
        {
            if (i < 0 || j < 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            if (i > Size || j > Size)
            {
                throw new ArgumentOutOfRangeException();
            }
        }
    }
}
