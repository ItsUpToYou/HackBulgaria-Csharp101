using System;
using System.Collections.Generic;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>() { 3, 2, 1, 4, 0 };
            list.BubleSortz(new MyCompare());
            Console.WriteLine(list);
        }
    }

    public static class SortAndSearchExtensions
    {
        public static IList<T> BubleSortz<T>(this IList<T> list, IComparer<T> comp)
        {
            for (int j = 0; j < list.Count; j++)
            {
                for (int i = 0; i < list.Count - 1; i++)
                {
                    int result = comp.Compare(list[i], list[i + 1]);
                    if (result > 0)
                    {
                        T num = default(T);
                        num = list[i];
                        list[i] = list[i + 1];
                        list[i + 1] = num;
                    }

                }
            }
            return list;
        }
    }

    public class MyCompare : IComparer<int>
    {
        public int Compare(int x, int y)
        {
            return x - y;
        }
    }
}
