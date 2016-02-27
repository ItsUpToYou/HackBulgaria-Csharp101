using System.Drawing;

namespace GrayscaleImage
{
    class Program
    {
        /*
        Make a program which loads a bitmap into memory, converts it to a grayscale image and then saves it to a file.

        void GreyScaleImage(Bitmap bitmap, string savePath)

        What is Grayscale

        Basically, you can use any linear combination of the color components:

        Gray = x.Red + y.Green + z.Blue, where x+y+z are floating point numbers which sum to 1.
         */

        static void Main(string[] args)
        {
            Bitmap bmp = new Bitmap("tiger.bmp");
            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    Color pixel = bmp.GetPixel(i, j);
                    int colors = (pixel.A + pixel.B + pixel.R) / 3;
                    Color newPixel = Color.FromArgb(colors, colors, colors);

                    bmp.SetPixel(i, j, newPixel);
                }
            }
            bmp.Save("newtiger.bmp");
        }
    }
}
