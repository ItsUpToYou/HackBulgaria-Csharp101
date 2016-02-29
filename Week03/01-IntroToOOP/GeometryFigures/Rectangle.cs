using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryFigures
{
    class Rectangle
    {
        public Point FirstPointRect { get; private set; }
        public Point SecondPointRect { get; private set; }

        public Point LeftUpperVertice { get; private set; }
        public Point RightDownVertice { get; private set; }
        public Point RightUpperVertice { get; private set; }
        public Point LeftDownVertice { get; private set; }

        public LineSegment LeftEdge { get; private set; }
        public LineSegment UpEdge { get; private set; }
        public LineSegment RightEdge { get; private set; }
        public LineSegment DownEdge { get; private set; }

        public Rectangle(Point p1, Point p2)
        {
            if (p1.X.Equals(p2.X) && p1.Y.Equals(p2.Y))
            {
                throw new ArgumentException("");
            }

            this.FirstPointRect = p1;
            this.SecondPointRect = p2;
            this.CalculateVertice();
        }

        public Rectangle(Rectangle points)
        {
            this.FirstPointRect = points.FirstPointRect;
            this.SecondPointRect = points.SecondPointRect;
        }

        private void CalculateVertice()
        {
            double X1 = (this.FirstPointRect.X < this.SecondPointRect.X) ? this.FirstPointRect.X : this.SecondPointRect.X;
            double X2 = (this.FirstPointRect.X < this.SecondPointRect.X) ? this.SecondPointRect.X : this.FirstPointRect.X;
            double Y1 = (this.FirstPointRect.Y < this.SecondPointRect.Y) ? this.FirstPointRect.Y : this.SecondPointRect.Y;
            double Y2 = (this.FirstPointRect.Y < this.SecondPointRect.Y) ? this.SecondPointRect.Y : this.FirstPointRect.Y;

            this.LeftUpperVertice = new Point(X1, Y2);
            this.LeftDownVertice = new Point(X1, Y1);
            this.RightUpperVertice = new Point(X2, Y2);
            this.RightDownVertice = new Point(X2, Y1);
        }



        public override string ToString()
        {
            return string.Format("(LU:{0}/{1}), LD:({2}/{3}), RU:({4}/{5}), RD:({6}/{7})",
                                   this.LeftUpperVertice.X,
                                   this.LeftUpperVertice.Y,
                                   this.LeftDownVertice.X,
                                   this.LeftDownVertice.Y,
                                   this.RightUpperVertice.X,
                                   this.RightUpperVertice.Y,
                                   this.RightDownVertice.X,
                                   this.RightDownVertice.Y);
        }
    

        public static bool operator ==(Rectangle first, Rectangle second)
        {
            if (first.Equals(second))
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(Rectangle first, Rectangle second)
        {
            if (!first.Equals(second))
            {
                return false;
            }
            return true;
        }

    }
}
