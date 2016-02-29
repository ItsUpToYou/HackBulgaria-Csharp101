using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryFigures
{
    class LineSegment
    {
        public Point A { get; }
        public Point B { get; }

        public LineSegment(Point lx, Point ly)
        {
            if (Point.Equals(lx, ly))
            {
                throw new ArgumentException("Cannot create a line segment with zero length");
            }
            this.A = lx;
            this.B = ly;
        }

        public LineSegment(LineSegment line)
        {
            this.A = line.A;
            this.B = line.B;
        }

        public double GetLength()
        {
            return (double)Math.Sqrt(Math.Pow(Math.Abs(B.X - A.X), 2) + Math.Pow(Math.Abs(B.Y - A.Y), 2));
        }

        public override bool Equals(object obj)
        {
            LineSegment line = (LineSegment)obj;
            if (line.A.Equals(A) && line.B.Equals(B))
            {
                return true;
            }
            return false;
        }

        public static bool operator ==(LineSegment first, LineSegment second)
        {
            return Equals(first, second);
        }

        public static bool operator !=(LineSegment first, LineSegment second)
        {
            return !Equals(first, second);
        }

        public static bool operator <(LineSegment first, LineSegment second)
        {
            if (first.GetLength() < second.GetLength())
            {
                return true;
            }
            return false;
        }

        public static bool operator >(LineSegment first, LineSegment second)
        {
            if (first.GetLength() > second.GetLength())
            {
                return true;
            }
            return false;
        }

        public static bool operator <=(LineSegment first, LineSegment second)
        {
            if (first.GetLength() < second.GetLength() || first.GetLength() == second.GetLength())
            {
                return true;
            }
            return false;
        }

        public static bool operator >=(LineSegment first, LineSegment second)
        {
            if (first.GetLength() > second.GetLength() || first.GetLength() == second.GetLength())
            {
                return true;
            }
            return false;
        }

        public static bool operator <(LineSegment line, double length)
        {
            if (line.GetLength() < length)
            {
                return true;
            }
            return false;
        }

        public static bool operator >(LineSegment line, double length)
        {
            if (line.GetLength() > length)
            {
                return true;
            }
            return false;
        }

        public static bool operator <=(LineSegment line, double lenght)
        {
            if (line.GetLength() < lenght || line.GetLength() == lenght)
            {
                return true;
            }
            return false;
        }

        public static bool operator >=(LineSegment line, double length)
        {
            if (line.GetLength() > length || line.GetLength() == length)
            {
                return true;
            }
            return false;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + A.GetHashCode();
                hash = hash * 23 + B.GetHashCode();
                return hash;
            }
        }
    }
}
