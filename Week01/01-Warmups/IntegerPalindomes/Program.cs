using System;

namespace IntegerPalindomes
{
    class Program
    {
        /*
        Check if given integer n is palindrome -> IsIntPalindrome(n)
        Largets palindrome, smaller than given N -> GetLargestPalindrome(N)
        For example, 1234321 is an integer palindrome.
        */

        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(isPolindrom(number));
            nextSmallerThanN(number);
        }

        private static void nextSmallerThanN(int number)
        {
            if (isPolindrom(number))
            {
                Console.WriteLine(number);
            }
            else
            {
                for (int i = number; i >= 0; i--)
                {
                    isPolindrom(i);
                    if (isPolindrom(i))
                    {
                        Console.WriteLine(i);
                        return;
                    }
                }

            }
        }

        private static bool isPolindrom(int number)
        {
            string num = number.ToString();
            for (int i = 0; i < num.Length / 2; i++)
            {
                if (num[i] != num[num.Length - i - 1])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
