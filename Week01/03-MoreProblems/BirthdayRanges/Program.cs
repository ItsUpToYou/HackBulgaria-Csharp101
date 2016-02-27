using System;
using System.Collections.Generic;

namespace BirthdayRanges
{
    class Program
    {
        /*
        Implement a function List<int> BirthdayRanges(List<int> birthdays, List<KeyValuePair<int, int>> ranges) We have a list birthdays and list of ranges. birthdays - range from 0 to 365, ranges - one range is a pair of two numbers - start and end.
        We want to calculate, for each range, how many people are born in it (between start and end inclusive).
        For example:

        Birthdays - {5, 10, 6, 7, 3, 4, 5, 11, 21, 300, 15}
        Ranges - {(4, 9), (6, 7), (200, 225), (300, 365)}
        Will give the result:

        {5, 2, 0, 1}
        As we can see, between 4 and 9, inclusive, there are 5 people with birthdays - 5, 6, 7, 4, 5.Between 300 and 365 there is exactly one birthday - 300.
        Test Examples:

        >>> BirthdayRanges({1, 2, 3, 4, 5}, {(1, 2), (1, 3), (1, 4), (1, 5), (4, 6)})
        {2, 3, 4, 5, 2}
        */

        static void Main(string[] args)
        {
            List<int> birthday = new List<int>()
                { 13, 7, 650, 22, 43, 84, 51, 27,150, 21, 300, 8, 111,69 };
            List<KeyValuePair<int, int>> range = new List<KeyValuePair<int, int>>() {
                new KeyValuePair<int, int>(7,22),
                new KeyValuePair<int, int>(84,300),
                new KeyValuePair<int, int>(111, 650),
                new KeyValuePair<int, int>(22,300)
            };

            foreach (var number in BirthdayRange(birthday, range))
            {
                Console.Write("{0} ", number);
            }
            Console.WriteLine();
        }

        static List<int> BirthdayRange(List<int> birthdays, List<KeyValuePair<int, int>> ranges)
        {
            List<int> result = new List<int>();

            for (int i = 0; i < ranges.Count; i++)
            {
                int counter = 0;

                for (int j = 0; j < birthdays.Count; j++)
                {
                    if ((birthdays[j] >= ranges[i].Key) && (birthdays[j] <= ranges[i].Value))
                    {
                        counter++;
                    }
                }
                result.Add(counter);
            }
            return result;
        }
    }
}
