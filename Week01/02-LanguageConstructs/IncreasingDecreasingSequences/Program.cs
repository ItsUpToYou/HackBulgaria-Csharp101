using System;

namespace IncreasingDecreasingSequences
{
    class Program
    {
        /*
        Implement the following functions:

        bool IsIncreasing(int[] sequence) which returns true if for every two consecutive elements a and b, a < b holds.
        bool IsDecreasing(int[] sequence) which returns true if for every two consecutive elements a and b, a > b holds.
        */

        static void Main(string[] args)
        {
            int[] seq = { 4, 6, 7, 8, 9 };
            Console.WriteLine("Increasing {0}",IsIncreasing(seq));

            int[] arr = { 23, 19, 18, 15, 13 };
            Console.WriteLine("Decreasing {0}",IsDecreasing(arr));
        }

        static bool IsIncreasing(int[] sequence)
        {
            bool isChecked = true;
            for (int i = 0; i < sequence.Length - 1; i++)
            {
                if (!(sequence[i] < sequence[i + 1]))
                {
                    isChecked = false;
                }
            }
            return isChecked;
        }

        static bool IsDecreasing(int[] sequence)
        {
            bool isChecked = true;
            for (int i = 0; i < sequence.Length - 1; i++)
            {
                if (!(sequence[i] > sequence[i + 1]))
                {
                    isChecked = false;
                }
            }
            return isChecked;
        }
    }
}
