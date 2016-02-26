using System;
using System.Collections.Generic;
using System.Linq;

namespace ExtremeElementsInList
{
    class Program
    {

        /*
        Implement the following functions:

        int Min(int[] items) - returns the mininum element in items
        int Max(int[] items) - returns the maximum element in items
        int NthMin(int n, int[] items) - returns the nth minimum element in items
        int NthMax(int n, int[] items) - returns the nth maximum element in items
        */

        static void Main(string[] args)
        {
            int[] numbers = { 12, 22, 5, 17, 29, 44, 8, 19 };
            Console.WriteLine(numbers.Min());
            Console.WriteLine(numbers.Max());
            int[] arranged = new int[numbers.Length];

            FindMin(numbers);
            FindMax(numbers);

            Console.WriteLine(NthMax(3, numbers));
            Console.WriteLine(NthMin(2, numbers));
        }

        static int FindMin(int[] numbers)
        {
            int minValue = int.MaxValue;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < minValue)
                {
                    minValue = numbers[i];
                }
            }
            return minValue;
        }

        static int FindMax(int[] numbers)
        {
            int maxValue = int.MinValue;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > maxValue)
                {
                    maxValue = numbers[i];
                }
            }
            return maxValue;
        }

        static int NthMin(int n, int[] items)
        {
            items = items.OrderByDescending(c => c).Reverse().ToArray();
            return items[n - 1];
        }

        static int NthMax(int n, int[] numbers)
        {
            List<int> temp = new List<int>();
            int nthMaximum = 0;

            for (int i = 0; i < n; i++)
            {
                temp.Add(FindMax(numbers));
                int numToRemove = FindMax(numbers);
                numbers = numbers.Where(val => val != numToRemove).ToArray();
            }

            for (int i = 0; i < temp.Count; i++)
            {
                nthMaximum = FindMin(temp.ToArray());
            }
            return nthMaximum;
        }
    }
}
