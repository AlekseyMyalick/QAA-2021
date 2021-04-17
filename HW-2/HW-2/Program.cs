using System;

namespace HW_2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine(MaximumNumberOfUnequalConsecutiveCharactersInStringVersionTwo(args[0]));
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        private static int MaximumNumberOfUnequalConsecutiveCharactersInStringVersionTwo(string characterSet)
        {
            if (string.IsNullOrEmpty(characterSet))
            {
                return 0;
            }

            int result = 1, count = 1, startIndex = 0, repeatingElementIndex;

            while (startIndex + count < characterSet.Length - 1)
            {
                repeatingElementIndex = StringContains(characterSet, characterSet[startIndex + count], startIndex, startIndex + count);

                if (repeatingElementIndex < 0)
                {
                    count++;
                }
                else
                {
                    startIndex = repeatingElementIndex + 1;
                    result = count > result ? count : result;
                    count = 1;
                }
            }

            return count > result ? count : result;
        }

        private static int StringContains(string line, char symbol, int startIndex, int endIndex)
        {
            for (int i = startIndex; i < endIndex; i++)
            {
                if (symbol.CompareTo(line[i]) == 0)
                {
                    return i;
                }
            }

            return -1;
        }

    }
}
