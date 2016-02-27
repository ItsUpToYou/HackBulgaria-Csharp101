using System;
using System.Drawing;

namespace PolygonArea
{
    class Program
    {
        /*
        Write a method which calculates the area of a given polygon.
        float CalcArea(PointF[] points)
        The polygon is given as an array of PointFs which represents a point with a floating point coordinates (from System.Drawing).
        The 0 index of the array contains the bottom-most point, and the next points are sorted counter-clockwise according to the point at 0.
        Hints: TBA
        */

        static void Main(string[] args)
        {
            PointF[] points =
            {
                new PointF(3f,3f),
                new PointF(2f,0f),
                new PointF(0f,1f),
                new PointF(1f,3f)
            };
            CalcPolygonArea(points);
        }

        private static void CalcPolygonArea(PointF[] p)
        {
            float prod = 0;
            for (int i = 0; i < p.Length; i++)
            {
                if (i == p.Length - 1)
                {
                    prod += (p[i].X * p[0].Y) - (p[0].X * p[i].Y);
                }
                else
                {
                    prod += (p[i].X * p[i + 1].Y) - (p[i + 1].X * p[i].Y);
                }
            }
            Console.WriteLine(prod / 2);
        }
    }
}
