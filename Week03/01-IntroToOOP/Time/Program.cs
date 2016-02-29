using System;

namespace Time
{
    class Program
    {
        /*
    In a Visual Studio project create a class Time to hold information about the current time and the current date .

    Make an easy-to-use constructor (from client perspective), that would represent the time and date the client wants to hold in your class.

    Implement the ToString() method, returning the time and date in format : "hh:mm:ss dd.MM.YY".

    Bonus Make a static method Now() for your class, returning the Time at the present moment :) (of type Time)
    */
        static void Main(string[] args)
        {
            var ourTime = new TimeInfo(new DateTime(2015, 02, 16, 14, 16, 00));
            Console.WriteLine(ourTime.ToString());

            var time = TimeInfo.Now();
            Console.WriteLine(time.ToString());
        }

        public class TimeInfo
        {
            private DateTime TimeNow { get; set; }

            public TimeInfo(DateTime tNow)
            {
                this.TimeNow = tNow;
            }

            public override string ToString()
            {
                return string.Format("Time: {0}", TimeNow.ToString());
            }

            public static TimeInfo Now()
            {
                TimeInfo nowTime = new TimeInfo(DateTime.Now);
                return nowTime;
            }
        }
    }
}
