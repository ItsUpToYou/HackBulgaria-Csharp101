using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithDigits
{
    class Program
    {
        /*
        Those are classic problems for using module division:

        Given an integer n, return the number of digits in n -> CountDigits(n)
        Given an integer n, return the sum of all digits in n -> SumDigits(n)
        FactorialDigits(n) -> for example, if we have 145, we need to calculate 1! + 4! + 5!
        */

        static void Main(string[] args)
        {
            int number = 1145;
            int sumNumb = 0;
            Console.WriteLine("Given an integer n, return the sum of all digits in n -> SumDigits(n)");
            while (number != 0)
            {
                sumNumb += number % 10;
                number /= 10;
                Console.WriteLine(sumNumb);
            }
            Console.WriteLine();
            Console.WriteLine("Given an integer n, return the number of digits in n->CountDigits(n)");

            int num = 14335;
            int lenght = 1;

            while ((num /= 10) >= 1)
            {
                lenght++;
            }
            Console.WriteLine(lenght);

            Console.WriteLine();
            Console.WriteLine("FactorialDigits(n) -> for example, if we have 145, we need to calculate 1! + 4! + 5!");
            int numA = 345;
            int factorialSum = 0;
            while (numA != 0)
            {
                factorialSum += Factorial(numA % 10);
                numA /= 10;
            }
            Console.WriteLine("Fasctorial of the digits {0}", factorialSum);
        }

        static int Factorial(int i)
        {
            if (i <= 1)
            {
                return 1;
            }
            else
            {
                return i * Factorial(i - 1);
            }
        }
    }
}
