using System;
using System.Globalization;

namespace RandomNumbers
{
    class Program
    {
        /*  
        Write a method which outputs a matrix of random floating point numbers to a file. 
        The dimensions of the matrix are given as arguments. The numbers should be in the range 0-1000 and should be printed with exactly two digits after the decimal point. The numbers should be separated by at least one space and should be right aligned to the size of their column (which you can consider to be fixed at 8 characters).
        void GenerateRandomMatrix(int rows, int columns, string fileName)
        3x3:
           13.37  545.87   75.64
          184.37 1000.00  684.64
            1.00    9.67  378.68
        Hint: Use File.WriteAllText to output the result.
        */
        static void Main(string[] args)
        {

            GenRandomMatrix(4, 5);
        }

        static void GenRandomMatrix(int rows, int columns)
        {
            float[,] matrix = new float[rows, columns];
            Random rnd = new Random();

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = (float)rnd.Next(0,1000) + (float)rnd.NextDouble();
                }
            }

            Console.WriteLine("{0}x{1}", rows, columns);
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    //File.WriteAllText(path ,matrix[row,col].ToString("0.00", CultureInfo.InvariantCulture).PadLeft(15));
                    Console.Write(matrix[row, col].ToString("0.00", CultureInfo.InvariantCulture).PadLeft(15));
                }
                Console.WriteLine();
            }
        }
    }
}
