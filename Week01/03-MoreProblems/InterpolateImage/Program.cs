using System;
using System.Drawing;

namespace InterpolateImage
{
    class Program
    {
        /*
        Make a program which loads a bitmap into memory, then rescales it into a new bitmap using the nearest neighbour interpolation.

        void ResampleImage(Bitmap bitmap, Size newSize, string savePath)
       */

        static void ResampleImage(Bitmap bitmap, Size newSize)
        {
            float procentHeight = (float)newSize.Height / bitmap.Height;
            float procentWidth = (float)newSize.Width / bitmap.Width;

            Bitmap newBitmap = new Bitmap(newSize.Width, newSize.Height);

            Color pixel;
            Color newPixel;

            double currX = 0;
            double currY = 0;

            for (int i = 0; i < newBitmap.Width; i++)
            {
                for (int j = 0; j < newBitmap.Height; j++)
                {
                    currX = Math.Round((i / procentWidth));
                    currY = Math.Round((j / procentHeight));

                    if (bitmap.Width > currX && bitmap.Height > currY)
                    {
                        pixel = bitmap.GetPixel((int)currX, (int)currY);
                        newPixel = Color.FromArgb(pixel.R, pixel.G, pixel.B);

                        newBitmap.SetPixel(i, j, newPixel);
                    }
                }
           } 
            newBitmap.Save("newtigerrr.bmp");
        }
        static void Main(string[] args)
        {
            Bitmap bmp = new Bitmap("tiger.bmp");
            Size newSize = new Size(600, 600);
            ResampleImage(bmp, newSize);
        }
    }
}
