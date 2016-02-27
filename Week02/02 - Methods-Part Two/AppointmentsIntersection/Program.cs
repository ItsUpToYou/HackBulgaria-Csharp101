using System;

namespace AppointmentsIntersection
{
    class Program
    {
        /* You are given a list of appointments and your task is to find the intersecting appointments. 
           Write a method which takes two equal-sized arrays as arguments and prints one line 
           for each pair of intersecting appointments. The line should be in the format:
           The appointment starting at dd/mm/yyyy hh:mm intersects the appointment starting at dd/mm/yyyy hh:mm 
           with exactly mmmm minutes.
        */

        static void Main(string[] args)
        {
            DateTime[] firstAppointm = new DateTime[]
            { new DateTime(2015, 11, 01, 14, 15, 00),
              new DateTime(2015, 11, 01, 16, 30, 00)
            };

            TimeSpan[] firstApp = new TimeSpan[] { new TimeSpan(2, 45, 0),
                                                    new TimeSpan(3, 0, 0)};

            FindIntersectingAppointments(firstAppointm, firstApp);
        }

        static void FindIntersectingAppointments(DateTime[] startDates, TimeSpan[] durations)
        {
            TimeSpan intersection = new TimeSpan();
            for (int i = 0; i < startDates.Length; i++)
            {
                for (int j = i + 1; j < startDates.Length; j++)
                {
                    if ((startDates[i].Add(durations[i]) > startDates[j]) && (startDates[i] < startDates[j].Add(durations[j])))
                    {
                        intersection = FirstInters(startDates, durations);
                        Console.WriteLine("The appointment starting at {0: dd/mm/yyyy hh:mm} intersects the appointment starting at {1: dd/mm/yyyy hh:mm} with exactly {2} minutes.", startDates[i], startDates[j], intersection.TotalMinutes);
                    }
                }
            }
        }

        static TimeSpan FirstInters(DateTime[] startDate, TimeSpan[] duration)
        {
            TimeSpan nonIntersect = new TimeSpan(0, 0, 0);
            for (int i = 0; i < startDate.Length; i++)
            {
                for (int j = i + 1; j < startDate.Length; j++)
                {
                    if (startDate[i] > startDate[j] && startDate[i].Add(duration[i]) < startDate[j].Add(duration[j]))
                    {
                        return startDate[j].Add(duration[j]) - startDate[i];
                    }

                    else if (startDate[i] < startDate[j] && startDate[i].Add(duration[i]) < startDate[j].Add(duration[j]))
                    {
                        return startDate[i].Add(duration[i]) - startDate[j];
                    }

                    else if (startDate[i] < startDate[j] && startDate[i].Add(duration[i]) < startDate[j].Add(duration[j]))
                    {
                        return duration[j];
                    }

                    else if (startDate[i] > startDate[j] && startDate[i].Add(duration[i]) > startDate[j].Add(duration[j]))
                    {
                        return duration[i];
                    }
                }
            }
            return nonIntersect;
        }
    }
}
