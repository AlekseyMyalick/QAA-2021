using System;

namespace HW_2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine(MaximumNumberOfUnequalConsecutiveCharactersInString(args[0]));
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        private static int MaximumNumberOfUnequalConsecutiveCharactersInString(string characterSet)
        {
            if (string.IsNullOrEmpty(characterSet))
            {
                return 0;
            }

            int result = 1, count = 1;

            for (int i = 0; i < characterSet.Length - 1; i++)
            {
                if (characterSet[i].CompareTo(characterSet[i + 1]) != 0)
                {
                    count++;
                }

                else
                {
                    result = count > result ? count : result;
                    count = 1;
                }
            }

            return count > result ? count : result;
        }
    }
}
