using System;
using System.Drawing;

namespace PolygonCircumference
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                   Write a method which calculates the circumference of a given polygon.
                   float CalcCircumference(PointF[] points)
                   The polygon is given as an array of PointFs which represents a point with a floating point coordinates (from System.Drawing).
                   The 0 index of the array contains the bottom-most point, and the next points are sorted counter-clockwise according to the point at 0.
                   Hints: TBA
               */
            PointF[] points =
            {
                new PointF(0f,4f),
                new PointF(1f,1f),
                new PointF(0f,1f),
                new PointF(2f,1f),
                new PointF(2f,1f)
            };
            Calculate(points);

        }

        static void Calculate(PointF[] points)
        {
            float sum = 0;
            for (int i = 0; i < points.Length; i++)
            {
                if (i == points.Length - 1)
                {
                    sum += (float)Math.Sqrt(Math.Pow((points[points.Length - 1].X - points[0].X), 2) + Math.Pow((points[points.Length - 1].Y - points[0].Y), 2));
                }
                else
                {
                    sum += (float)Math.Sqrt(Math.Pow((points[i + 1].X - points[i].X), 2) + Math.Pow((points[i + 1].Y - points[i].Y), 2));
                }
            }
            Console.WriteLine(sum);
        }
    }
}
