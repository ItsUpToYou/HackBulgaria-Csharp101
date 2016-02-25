using System;

namespace FibonacciNumber
{
    class Program
    {
        /*
        Implement a function, called FibNumber(n), which takes an integer n and returns a number,
        which is formed by concatenating the first n Fibonacci numbers.

        Examples:

        FibNumber(3) = 112
        FibNumber(10) = 11235813213455
        */

        static int Fibonacci(int i)
        {
            int a = 1;
            int b = 1;

            for (int h = 0; h < i; h++)
            {
                int temp = a;
                a = b;
                b = temp + b;
            }
            return a;
        }

        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            for (int i = 0; i < input; i++)
            {
                Console.WriteLine(Fibonacci(i));
            }
        }
    }
}
