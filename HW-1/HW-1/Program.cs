using System;

namespace HW_1
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        private static int[] ArrayOfPowersOfTwo(int amountOfNumbers)
        {
            if (amountOfNumbers < 0)
            {
                throw new ArgumentException();
            }

            int[] arr = new int[amountOfNumbers];
            arr[0] = 1;

            for (int i = 1; i < amountOfNumbers; i++)
            {
                arr[i] = arr[i - 1] * 2;
            }

            return arr;
        }

        private static int[] SwapMinimumAndMaximum(int[] arr)
        {
            if (arr is null)
            {
                throw new ArgumentNullException();
            }

            if (arr.Length == 0)
            {
                throw new ArgumentException();
            }

            int indexOfMaximim = 0;
            int indexOfMinimum = 0;

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > arr[indexOfMaximim])
                {
                    indexOfMaximim = i;
                }

                if (arr[i] < arr[indexOfMinimum])
                {
                    indexOfMinimum = i;
                }
            }

            int temp = arr[indexOfMinimum];
            arr[indexOfMinimum] = arr[indexOfMaximim];
            arr[indexOfMaximim] = temp;

            return arr;
        }

        private static double Mean(int[] arr)
        {
            if (arr is null)
            {
                throw new ArgumentNullException();
            }

            if (arr.Length == 0)
            {
                return 0;
            }

            double sum = 0;

            foreach (int item in arr)
            {
                sum += item;
            }

            return sum / arr.Length;
        }
    }
}
