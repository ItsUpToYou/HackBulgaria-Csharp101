using System;

namespace JoiningStrings
{
    class Program
    {
        /*
        Write a method which takes an arbitrary number of strings and joins them using the specified separator.
        string JoinStrings(string separator, params string[] strings)
        */

        //static int Sum(params int[] number)
        //{
        //    int sum = 0;
        //    for (int i = 0; i < number.Length; i++)
        //    {
        //        sum += number[i];
        //    }
        //    return sum;
        //}

        static string JoinStrings(string separator, params string[] strings)
        {
            string addStr = string.Empty;

            foreach (String str in strings)
            {
                addStr += str + separator;
            }
            return addStr.Substring(0, addStr.Length - separator.Length);
        }
        static void Main(string[] args)
        {
            //int s = Sum(34, 345, 124, 345, 345, 345, 3456, 234);
            //Console.WriteLine(s);
            //int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 4 };
            //s = Sum(array);
            //Console.WriteLine(s);

            string result = JoinStrings("$#", "aaa", "bbb", "ccc");
            Console.WriteLine(result);
        }
    }
}
