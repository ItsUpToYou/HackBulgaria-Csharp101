using System;
using System.Drawing;

namespace LinearFilter
{
    class Program
    {
        /*
           Make a program which loads a bitmap into memory, then applies a linear filter and saves it into a new file.

           You can use the Box Blur Filter

           void BlurImage(Bitmap bitmap, string savePath)
        */

        static void Main(string[] args)
        {
            Bitmap myBmp = (Bitmap)Image.FromFile("tiger.bmp");
            BlurEffImage(myBmp, "blurTiger.bmp");
        }

        static void BlurEffImage(Bitmap bmap, string savePath)
        {
            Bitmap blurBmp = new Bitmap(bmap.Width, bmap.Height);

            for (int x = 0; x < bmap.Width; x++)
            {
                for (int y = 0; y < bmap.Height; y++)
                {
                    int newA = 0;
                    int newR = 0;
                    int newG = 0;
                    int newB = 0;
                    int counter = 0;


                    for (int i = -1; i <= 1; i++)
                    {
                        for (int j = -1; j <= 1; j++)
                        {
                            if (x + i > 0 && x + i < (bmap.Width - 1) && y + j > 0 && y + j < (bmap.Height - 1))
                            {
                                Color pixel = bmap.GetPixel(x + i, y + j);
                                newA += pixel.A;
                                newR += pixel.R;
                                newG += pixel.G;
                                newB += pixel.B;
                                counter++;

                            }
                        }
                    }

                    newA = (int)Math.Round((double)newA / counter);
                    newR = (int)Math.Round((double)newR / counter);
                    newG = (int)Math.Round((double)newG / counter);
                    newB = (int)Math.Round((double)newB / counter);

                    Color newColor = Color.FromArgb(newA, newR, newG, newB);
                    blurBmp.SetPixel(x, y, newColor);
                }
            }
            blurBmp.Save(savePath);
        }
    }
}
