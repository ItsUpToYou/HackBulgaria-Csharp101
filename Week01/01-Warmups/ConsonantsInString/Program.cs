using System;
using System.Linq;

namespace ConsonantsInString
{
    class Program
    {
        /*
        mplement a function, called CountConsonants(str), which returns the count of all consonants in the string str.

        Count uppercase consonants as well!

        The English consonants are bcdfghjklmnpqrstvwxz.
        */

        static void Main(string[] args)
        {

            Console.WriteLine("Enter your letters");
            string inputLetter = Console.ReadLine();
            int result = CountConsonants(inputLetter);
            Console.WriteLine("Consonants letters are {0}", result);
        }

        static int CountConsonants(string sentence)
        {
            int total = 0;
            char[] vowels = " bcdfghjklmnpqrstvwxzBCDFGHJKLMNPQRSTVWXZ".ToCharArray();

            for (int i = 0; i < sentence.Length; i++)
            {
                if (!vowels.Contains(sentence[i]))
                {
                    total++;
                }
            }
            return total;
        }
    }
}
