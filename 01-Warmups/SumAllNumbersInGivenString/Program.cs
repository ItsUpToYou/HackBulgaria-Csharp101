using System;
using System.Text.RegularExpressions;

namespace SumAllNumbersInGivenString
{
    class Program
    {

        /*
        You are given a string, where there can be numbers. Return the sum of all numbers in that string (not digits, numbers)

        Examples:

        SumOfNumbersInString("1111") = 1111
        SumOfNumbersInString("1abc33xyz22") = 1 + 33 + 22 = 56
        SumOfNumbersInString("abcd") = 0
        */

        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string[] numbers = Regex.Split(text, @"\D+");
            int sum = 0;
            foreach (string item in numbers)
            {
                if (!string.IsNullOrEmpty(item))
                {
                    int i = int.Parse(item);
                    sum += i;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
