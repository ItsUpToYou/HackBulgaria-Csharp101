using System;
using System.Collections.Generic;

namespace MaxSpan
{
    class Program
    {
        /*
           mplement the following function: int MaxSpan(List<int> numbers) where numbers is a list of numbers.

           Consider the leftmost and rightmost appearances of some value in the list.

           We'll say that the "span" is the number of elements between the two inclusive. A single value has a span of 1.

           Returns the largest span found in the given array.
        */

        static int MaxSpan(List<int> numbs)
        {
            if (numbs.Count == 1)
            {
                return 1;
            }

            int maxSpn = 0;
            int index = 0;

            for (int i = 0; i < numbs.Count; i++)
            {
                index = i;
                for (int j = i + 1; j < numbs.Count; j++)
                {
                    if (numbs[i] == numbs[j])
                    {
                        index = j;
                    }
                }

                if (maxSpn < index - i + 1)
                {
                    maxSpn = index - i + 1;
                }
            }
            return maxSpn;
        }
        static void Main(string[] args)
        {
            List<int> ls1 = new List<int>() { 1, 2, 1, 1, 3 };

            Console.WriteLine(MaxSpan(ls1));

            List<int> ls2 = new List<int>() { 1, 4, 6, 1, 4, 4, 6, 7, 8, 8, 9, 6 };

            Console.WriteLine(MaxSpan(ls2));
        }
    }
}
