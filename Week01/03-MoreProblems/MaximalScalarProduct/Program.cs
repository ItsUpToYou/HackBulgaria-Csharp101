using System;
using System.Collections.Generic;

namespace MaximalScalarProduct
{
    class Program
    {
        /*
        Implement the following function:

        int MaxScalarProduct(List<int> v1, List<int> v2).

        You are given two vectors - v1 and v2. A scalar product of two vectors is the following:

        v1 = {a1, a2, ..., an}
        v2 = {b1, b2, ..., bn}

        The scalar product is written as:
        v1 . v2 = a1 * b1 + a2 * b2 + ... + an * bn
        Find a permutation of v1 and a permutation of v2 for which their scalar product is the largest possible
        */

        static int MaxScalarProduct(List<int> first, List<int> second)
        {
            if (first.Count < second.Count)
            {
                for (int i = 0; i < second.Count - first.Count; i++)
                {
                    first.Add(0);
                }
            }

            else if (second.Count < first.Count)
            {
                for (int i = 0; i < first.Count - second.Count; i++)
                {
                    second.Add(0);
                }
            }

            first.Sort();
            second.Sort();
            int result = 0;

            for (int i = 0; i < first.Count; i++)
            {
                result += (first[i] * second[i]);
            }
            return result;
        }
        static void Main(string[] args)
        {
            List<int> first = new List<int>() { 5, 13, 9 };

            List<int> second = new List<int>() { 9, 5, 13 };

            Console.WriteLine(MaxScalarProduct(first, second));

        }

    }
}
