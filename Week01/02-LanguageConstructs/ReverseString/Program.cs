using System;

namespace ReverseString
{
    class Program
    {
        /*
        Implement a function which takes a string and returns the same in a reversed order.
        string ReverseMe(string original)
         */

        static void Main(string[] args)
        {
            string word = "abcdef";
            char[] wordArr = word.ToCharArray();
            char[] reverse = new char[wordArr.Length];

            for (int i = 0; i < wordArr.Length; i++)
            {
                reverse[i] = wordArr[wordArr.Length - i - 1];
            }
            Console.WriteLine(reverse);
        }
    }
}
