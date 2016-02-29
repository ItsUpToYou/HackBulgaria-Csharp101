using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryFigures
{
    class Point
    {
        double x;
        double y;

        public double X
        {
            get
            {
                return x;
            }
        }

        public int Y
        {
            get
            {
                return y;
            }
        }

        public static readonly Point origingCoord = new Point(0, 0);

        public Point()
        {
            this.x = p.X;
            this.y = p.Y;
        }  

        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public Point(Point p)
        {
            this.x = p.X;
            this.y = p.Y;
        }

        public override string ToString()
        {
            return string.Join("{0}:{1}", X, Y);
        }

        public override bool Equals(object obj)
        {
            Point item = obj as Point;

            if (item == null)
            {
                return false;
            }

            return (X == item.X) && (Y == item.Y);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + X.GetHashCode();
                hash = hash * 23 + Y.GetHashCode();
                return hash;
            }
        }

        //public static bool operator ==(Point a, Point b)
        //{
        //    bool status = false;
        //    if (a.X == b.X && a.Y == b.Y)
        //    {
        //        status = true;
        //    }
        //    return status;
        //}

        public static LineSegment operator +(Point a, Point b)
        {
            return new LineSegment(a, b);
        }

        //public static bool operator !=(Point a, Point b)
        //{
        //    bool status = false;
        //    if (a.X != b.X && a.Y != b.Y)
        //    {
        //        status = true;
        //    }
        //    return status;
        //}
    }
}
