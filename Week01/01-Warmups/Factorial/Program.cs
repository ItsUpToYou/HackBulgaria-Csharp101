using System;

namespace Factorial
{
    class Program
    {
        /*
        In the given language, implement the factorial function n!.
        -Implement it using a simple loop
        -Implement it using recursion
        */

        static void Main(string[] args)
        {
            int numberInt = int.Parse(Console.ReadLine());
            int result = numberInt;
            Console.WriteLine();

            for (int i = 1; i < numberInt; i++)
            {
                result = result * i;
                Console.WriteLine(result);
            }
        }

        public static void FactLop(int numberInt)
        {
            //int numberInt = int.Parse(Console.ReadLine());
            int result = numberInt;
            Console.WriteLine();

            for (int i = 1; i < numberInt; i++)
            {
                result = result * i;
                Console.WriteLine(result);
            }
        }
    }
}