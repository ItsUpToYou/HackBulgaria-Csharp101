using System;

namespace LucasSeries
{
    class Program
    {
        /*
        Because Fibonacci is way too trivial, implement the following functions that work with Lucas series:

        NthLucas(n) -> returns the nth Lucas number
        FirstNLucas(n) -> returns a list of the first n Lucas numbers
        Quick hint:

        L(0) = 2
        L(1) = 1
        L(n) = L(n-1) + L(n-2)
        */

        static void Main(string[] args)
        {
            int numberInt = int.Parse(Console.ReadLine());
            int result = numberInt;
            Console.WriteLine();

            int prev1 = 2;
            int prev2 = 1;

            for (int i = 0; i <= numberInt; i++)
            {
                if (i == 0)
                {
                    Console.WriteLine(prev2);
                }
                else if (i == 1)
                {
                    Console.WriteLine(prev1);
                }
                else
                {
                    result = prev1 + prev2;
                    Console.WriteLine(result);

                    prev2 = prev1;
                    prev1 = result;
                }
            }



            int addNumber = int.Parse(Console.ReadLine());
            Console.WriteLine(Factorial(addNumber));
        }

        static int Factorial(int i)
        {
            if (i == 1)
            {
                return 1;
            }
            else if (i == 2)
            {
                return 2;
            }
            else
            {
                return Factorial(i - 1) + Factorial(i - 2);
            }
        }
    }
}
