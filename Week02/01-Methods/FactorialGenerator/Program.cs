using System;
using System.Collections.Generic;

namespace FactorialGenerator
{
    class Program
    {
        /*
            Write a method which generates all the factorials of the integers up to n. Use the yield operator.
            IEnumerable<int> GenerateFactorials(int n)
        */

        static IEnumerable<int> GenerateFactorials(int n)
        {
            int num = 1;

            for (int i = 2; i < n; i++)
            {
                num *= i;
                yield return num;
            }
        }

        static void Main(string[] args)
        {
            foreach (var item in GenerateFactorials(10))
            {
                Console.WriteLine(item);
            }

        }
    }
}
