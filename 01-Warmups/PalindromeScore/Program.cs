using System;
using System.Text;

namespace PalindromeScore
{
    class Program
    {
        /*
        We denote the "Palindrome score" of an integer by the following function:

        P(n) = 1, if n is palindrome
        P(n) = 1 + P(s) where s is the sum of n and the reverse of n
        Implement a function, called PScore(n), which finds the palindrome score for n.

        Lets see two examples:

        PScore(121) = 1, because 121 is a palindrome.
        PScore(48) = 3, because:

        P(48) = 1 + P(48 + 84) = 132
        P(132) = 1 + 1 + P(132 + 321 = 363)
        P(363) = 1.
        When we return from the recursion, we get 3.
        */

        static int counter = 0;
        static void Main(string[] args)
        {
            string num = Console.ReadLine();
            Console.WriteLine(Score(num));
        }

        private static string Score(string num)
        {
            counter++;
            if (isPalindrome(num))
            {
                return counter.ToString();
            }
            return Score(scoreP(num));
        }

        private static string scoreP(string num)
        {
            int revnum = int.Parse(Reverse(num));
            int number = int.Parse(num);
            num = (revnum + number).ToString();
            return num;
        }

        private static string Reverse(string num)
        {
            char[] arrNum = num.ToCharArray();
            StringBuilder sb = new StringBuilder();
            for (int i = arrNum.Length - 1; i >= 0; i--)
            {
                sb.Append(arrNum[i]);
            }
            return sb.ToString();
        }

        private static bool isPalindrome(string num)
        {
            char[] arrNum = num.ToCharArray();
            for (int i = 0; i < (arrNum.Length / 2) + 1; i++)
            {
                if (arrNum[i] != arrNum[arrNum.Length - i - 1])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
