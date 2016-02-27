using System;

namespace MatrixBombing
{
    class Program
    {

        /*
            You are given a NxM matrix of integer numbers.
            We can drop a bomb at any place in the matrix, which has the following effect:
            All of the 3 to 8 neighbours (depending on where you hit!) of the target are reduced by the value of the target.
            Numbers can be reduced only to 0 - they cannot go to negative.
            For example, if we have the following matrix:
            10 10 10
            10  9  10
            10 10 10
            and we drop bomb at 9, this will result in the following matrix:
            1 1 1
            1 9 1
            1 1 1
            Implement a function called int MatrixBombing(int[,] m).
            The function should return the maximum damage we can inflict by bombing a single cell. The damage in each cell is calculated as the difference between the old value and value after bombing.
            For example if we have the following matrix:
            1 2  3  4
            5 6  7  8
            9 10 11 12
            and run the function, we will have : 43 - the damage if we bomb at 7
        */
        static void Main(string[] args)
        {
            int[,] matrix = new int[,] {{1, 2, 3, 4},
                                        {5, 6, 7, 8},
                                        {9, 10, 11, 12}};
            Console.WriteLine(MatrixBombing(matrix));
        }

        static int MatrixBombing(int[,] arr)
        {
            int rows = arr.GetLength(0);
            int cols = arr.GetLength(1);

            int totalDamage = 0;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    int tmpDamage = 0;

                    for (int k = i - 1; k <= i + 1; k++)
                    {
                        for (int l = j - 1; l <= j + 1; l++)
                        {
                            if (k != i || l != j)
                            {
                                try
                                {
                                    tmpDamage += arr[i, j] < arr[k, l] ? arr[i, j] : arr[k, l];
                                }
                                catch (IndexOutOfRangeException) { }
                            }
                        }
                    }
                    if (totalDamage < tmpDamage)
                        totalDamage = tmpDamage;
                }
            }
            return totalDamage;
        }
    }
}
