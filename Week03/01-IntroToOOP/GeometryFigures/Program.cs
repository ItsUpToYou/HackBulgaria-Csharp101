using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(2.4, 3.6);
            Point p2 = new Point(p1);
            Point p3 = new Point(3.4, 5.6);
            Point p4 = new Point();

            Console.WriteLine(p1.ToString());
            Console.WriteLine(p2.ToString());
            Console.WriteLine(p3.ToString());
            Console.WriteLine(p4.ToString());
            Console.WriteLine(p1.Equals(p2));
            Console.WriteLine(p2.Equals(p3));
            Console.WriteLine(p1 == p2);
            Console.WriteLine(p1 == p3);

            LineSegment line1 = new LineSegment(p1, p3);
            LineSegment line2 = new LineSegment(p4, p1);

            Console.WriteLine(line1.Equals(line2));
            Console.WriteLine(line1 == line2);
            Console.WriteLine(line1.ToString());
            Console.WriteLine(line1 > line2);
            Console.WriteLine(line2 >= 3.0);

            Point left = new Point(1, 1);
            Point right = new Point(7, 5);
            Point c = new Point(4, 3);

            Rectangle rect1 = new Rectangle(left, right);
            Rectangle rect2 = new Rectangle(c, right);
            Rectangle rect3 = new Rectangle(rect1);

            Console.WriteLine(rect3.ToString());
            Console.WriteLine(rect1.Equals(rect2));
            Console.WriteLine(rect1.Equals(rect3));
            Console.WriteLine(rect1 == rect2);
            Console.WriteLine(rect2 != rect3);

            Vector v1 = new Vector(1, 3, 5);
            Vector v2 = new Vector(2, 4, 6);
            Vector v3 = new Vector(v1);

            Console.WriteLine(v1.ToString());
            Console.WriteLine(v1.Equals(v2));
            Console.WriteLine(v1.Equals(v3));
            Console.WriteLine((v1 + v2).ToString());
            Console.WriteLine((v2 - v1).ToString());
            Console.WriteLine((v1 * v2).ToString());
            
        }
    }
    }
}
