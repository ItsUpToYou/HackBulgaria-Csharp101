using System;
using System.Drawing;

namespace InflateRectangle
{
    class Program
    {
        /*
            Write a method which takes a rectangle as an argument and inflates it with the specified size in all directions. This means that if you get a rectangle (x:0,y:0,w:10,h:10) and inflate it with a size of (2,2), the resulting rectangle should be (x:-2,y:-2,w:14,h:14). Use the ref keyword to store the result in the same variable.
            void Inflate(ref Rectangle rect, Size inflateSize)
            Note: Rectangle and Size are structs defined in the System.Drawing assembly.
        */

        static void Inflate(out Rectangle rect, Size inflateSize)
        {
            Rectangle recCopy = new Rectangle();
            rect = recCopy;

            rect.Height += 2 * inflateSize.Height;
            rect.Width += 2 * inflateSize.Width;
            rect.X -= inflateSize.Width;
            rect.Y -= inflateSize.Height;
        }

        static void Main(string[] args)
        {
            Rectangle rectBound = new Rectangle();
            rectBound.X = 0;
            rectBound.Y = 0;
            rectBound.Width = 10;
            rectBound.Height = 10;
            //rectbounding.inflate(2, 2);
            //console.writeline(rectbounding);

            Size sz = new Size(2, 2);
            Inflate(out rectBound, sz);

            Console.WriteLine(rectBound);
        }
    }
}
