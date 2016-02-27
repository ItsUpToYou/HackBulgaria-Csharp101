using System;

namespace FridayThe13th
{
    class Program
    {
        /*
        Write a method which given a year range, returns how many Fridays 13ths there are in that range
        int UnfortunateFridays(int startYear, int endYear)
        */

        static void Main(string[] args)
        {
            int showFridays = UnfortunateFridays(2015, 2016);
            Console.WriteLine(showFridays);
        }

        static int UnfortunateFridays(int startYears, int endYears)
        {
            DateTime startYear = new DateTime(startYears, 01, 13);
            DateTime endYear = new DateTime(endYears, 12, 31);
            int countFridays = 0;
            for (int i = startYear.Year; i <= endYear.Year; i++)
            {
                while (startYear < endYear)
                {
                    if (startYear.Day == 13 && startYear.DayOfWeek == DayOfWeek.Friday)
                    {
                        countFridays++;
                        Console.WriteLine(startYear.Date);
                    }
                    startYear = startYear.AddMonths(1);
                }
            }
            return countFridays;
        }
    }
}