using System;
using System.Linq;

namespace VowelsInString
{
    class Program
    {
        /*
        Implement a function, called CountVowels(str), which returns the count of all vowels in the string str.

        Count uppercase vowels aswell!

        The English vowels are aeiouy.
        */

        static void Main(string[] args)
        {
            {
                Console.WriteLine("Enter a Sentence");
                string sentence = Console.ReadLine();
                int totalSum = CountVowels(sentence);

                Console.WriteLine("Your total number of vowels is: {0}", totalSum);
            }
        }

        static int CountVowels(string sentence)
        {
            int total = 0;
            char[] vowels = "AEIOUYaeiouy".ToCharArray();
            total = sentence.Count(x => vowels.Contains(x));
            return total;
        }
    }
}
