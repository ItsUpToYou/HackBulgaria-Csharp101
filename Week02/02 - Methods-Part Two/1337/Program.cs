using System;

namespace _1337
{
    class Program
    {
        /*  When the clock hits 13:37 on December 21st, this is a special time for hackers.
            Write a method which prints how many days, hours, and minutes remain until the next such time comes.
            void Hackertime()
            The result should be printed on the console in the format dd: hh:mm 
        */
        static void Main(string[] args)
        {
            Hackertime();
        }

        static void Hackertime()
        {
            DateTime now = DateTime.Now;
            DateTime hackerTime = new DateTime(DateTime.Now.Year, 12, 21, 13, 37, 00);

            TimeSpan interval;
            if (now > hackerTime)
            {
                hackerTime = hackerTime.AddYears(1);
            }

            interval = hackerTime - now;

            Console.WriteLine("{0}days:{1}h:{2}min", interval.Days, interval.Hours, interval.Minutes);
            Console.WriteLine("   {0,-35} {1,20:N0}", "Ticks:", interval.Ticks);
        }
    }
}
