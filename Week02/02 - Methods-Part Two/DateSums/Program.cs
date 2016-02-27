using System;
using System.Collections.Generic;

namespace DateSums
{
    class Program
    {
        /* Find all dates in a given year whose digits of the month number, 
           the digits of the day number and the digits of the year sum up to a given value. 
           Print each of them on the console in the format: dd / mm / yyyy: d + d + m + m + y + y + y + y = sum
        */

        static void Main(string[] args)
        {
            PrintDatesWithGivenSum(2015, 17);
        }

        static void PrintDatesWithGivenSum(int year, int sum)
        {
            DateTime enterDate = new DateTime(year, 1, 1);
            int a = enterDate.Year;
            while (enterDate.Year == year)
            {
                int curSum = 0;

                curSum += SumParsedDigits(enterDate.Year);
                curSum += SumParsedDigits(enterDate.Month);
                curSum += SumParsedDigits(enterDate.Day);

                if (curSum == sum)
                {
                    // print
                    Console.WriteLine(enterDate.ToShortDateString());
                    Console.WriteLine(enterDate.ToLongDateString());
                }

                enterDate = enterDate.AddDays(1);
            }
        }

        public static int SumParsedDigits(int number)
        {
            List<int> list = new List<int>();
            int sum = 0;

            while (number > 0)
            {
                list.Add(number % 10);
                number /= 10;
            }

            list.ForEach(i => sum += i);

            return sum;
        }
    }
}
