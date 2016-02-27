using System;

namespace ClockAngle
{
    class Program
    {
        /*
        Write a method which calculates the angle (degree) between clock hour and minute hands.
        int GetClockHandsAngle(DateTime time)
        1) Calculate the angle if you consider that the hour hand points to exact hour (when the time is 4:34 then the hour hand points exactly to 4 o'clock)
        2) Calculate the angle if the hour hand points doesn't point exactly to the number (when the time is 4:30 then the hour hand points to the middle between 4 and 5 o'clock)
        Example : the angle is 90 degrees at 3:00, 15:00, 9:00 and 21:00
        Hint : Use Math library
        */

        public static void Main()
        {
            DateTime time = new DateTime(2015, 11, 22, 15, 00, 0);
            DateTime time1 = new DateTime(2015, 11, 22, 12, 30, 0);
            Console.WriteLine("Angle is {0} degree",GetClockHandsAngle(time, true));
            Console.WriteLine("Angle is {0} degree",GetClockHandsAngle(time1, false));
        }

        static int GetClockHandsAngle(DateTime time, bool hourIsExact)
        {
            int hourDegr, minDegr, angle;

            if (hourIsExact)
            {
                if (time.Hour >= 12)
                {
                    time = new DateTime(time.Year, time.Month, time.Day, time.Hour - 12, time.Minute, time.Second);
                    
                }
               
                    hourDegr = time.Hour * 30;
                    minDegr = time.Minute * 6;
                    angle = Math.Abs(hourDegr - minDegr);

              return (angle < 180 ? angle : 360 - angle);
            }
            else
            {
                if (time.Hour >= 12)
                {
                    time = new DateTime(time.Year, time.Month, time.Day, time.Hour - 12, time.Minute, time.Second);
                }
              
                    hourDegr = (time.Hour * 60 + time.Minute) * (1 / 2);
                    minDegr = time.Minute * 6;
                    angle = Math.Abs(hourDegr - minDegr);
               
            }
            return (angle < 180 ? angle : 360 - angle); ;
        }
    }
}
