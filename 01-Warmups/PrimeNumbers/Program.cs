using System;
using System.Collections.Generic;

namespace PrimeNumbers
{
    class Program
    {
        /*
        The usual deal:

        Check if number is prime -> IsPrime(n)
        List the first n prime numbers -> ListFirstPrimes(n)
        List the first n prime numbers, using the Sieve of Eratosthenes
        */
        public static bool IsPrime(int number)
        {
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        public static List<int> ListFirstPrimes(int number)
        {
            List<int> primesList = new List<int>();
            for (int i = 0; i < number; i++)
            {
                if (IsPrime(i))
                {
                    primesList.Add(i);
                }
            }

            return primesList;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number to check and the list of prime numbers smaller than yours :");
            int input = int.Parse(Console.ReadLine());
            ListFirstPrimes(input);

            foreach (int number in ListFirstPrimes(input))
            {
                Console.Write(number + " ");
            }

            Console.WriteLine();
        }
    }
}
