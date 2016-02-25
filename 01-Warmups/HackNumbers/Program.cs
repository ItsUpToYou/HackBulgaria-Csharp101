using System;
using System.Collections.Generic;
using System.Linq;

namespace HackNumbers
{
    class Program
    {
        /*
        A hack number is an integer, that matches the following criteria:

        The number, represented in binary, is a palindrome
        The number, represented in binary, has an odd number of 1's in it
        Example of hack numbers:

        1 is 1 in binary
        7 is 111 in binary
        7919 is 1111011101111 in binary
        Implement the following functions:

        IsHack(n) -> checks if n is a hack number
        NextHack(n) -> returns the next hack number, that is bigger than n
        */

        static void Main(string[] args)
        {
            Console.WriteLine(isHack(8));
            Console.WriteLine(FindNextHack(8));
        }

        static bool isHack(int input)
        {
            string str = input.ToString();
            int result = input;
            bool isHackNum = false;
            List<int> digits = new List<int>();

            while (result > 0)
            {
                digits.Add(result % 2);
                result /= 2;
            }

            List<int> reversedDigits = digits.Reverse<int>().ToList();
            for (int i = 0; i < digits.Count && i < reversedDigits.Count; i++)
            {
                if (digits[i] != reversedDigits[i])
                {
                    isHackNum = false;
                }
                else
                {
                    isHackNum = true;
                }
            }
            return isHackNum;
        }

        static int FindNextHack(int input)
        {
            int nextHack = input + 1;

            while (true)
            {
                if (isHack(nextHack))
                {
                    return nextHack;
                }
                nextHack++;
            }
            return -1;
        }
    }
}

