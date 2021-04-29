using System;

namespace Matrix
{
    class DiagonalMatrix : SquareMatrix
    {
        public DiagonalMatrix(int size) : base(size)
        {
            matrix = new int[size]; 
        }

        public override int this[int i, int j]
        {
            get
            {
                CheckingMatrixIndices(i, j);
                return matrix[i];
            }
            set
            {
                CheckingMatrixIndices(i, j);
                matrix[i] = value;
            }
        }

        public override void CheckingMatrixIndices(int i, int j)
        {
            if (i != j)
            {
                throw new ArgumentOutOfRangeException();
            }
        }
    }
}
