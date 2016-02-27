using System;

namespace Calendar
{
    class Program
    {
        /*
          Write a method which prints on the console the calendar for and specified month and year. The calendar should be localized according to a certain culture.
          void PrintCalendar(int month, int year, CultureInfo culture)
          The first line should contain the name of the month, the second line the names of the weekdays space-separated, and the next lines should the month day numbers, each right-aligned to the column of its week.
          Example:
          PrintCalendar(11,2015, new CultureInfo("bg-BG")):
          Ноември
          понеделник вторник сряда четвъртък петък събота неделя
                   1       2     3         4     5      6      7
                   8       9    10        11    12     13     14
                  15      16    17        18    19     20     21
                  22      23    24        25    26     27     28       
                  29      30     
          */

        static void Main(string[] args)
        {
            PrintCalendar(11, 2015);

        }

        static void PrintCalendar(int month, int year)
        {
            DateTime date = new DateTime(year, month, 1);
            DateTime nextDate = date.AddMonths(1);
            int sunday = 7;

           // Console.OutputEncoding = Encoding.Default;
           // Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("bg-BG");
            Console.WriteLine(date.ToString("MMMM"));

            for (int i = 0; i <= 6; i++)
            {
                Console.Write(date.ToString("dddd").PadRight(15));
                date = date.AddDays(1);
            }
            Console.WriteLine();

            date = new DateTime(year, month, 1);
            for (DateTime i = date; i < nextDate; i = i.AddDays(1))
            {
                Console.Write(date.ToString("dd").PadRight(15));

                if (sunday == date.Day)
                {
                    Console.WriteLine();
                    sunday += 7;
                }

                date = date.AddDays(1);
            }
        }
    }
}
