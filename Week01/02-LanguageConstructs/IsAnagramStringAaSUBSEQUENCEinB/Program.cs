using System;

namespace IsAnagramStringAaSUBSEQUENCEinB
{
    class Program
    {
        /*
        Return whether an anagram of String A can be found in String B.

        bool HasAnagramOf(string A,string B)
        */

        static void Main(string[] args)
        {
            string one = Console.ReadLine();
            string two = Console.ReadLine();
            Console.WriteLine(isAnagrams(one, two));
        }

        private static bool isAnagrams(string one, string two)
        {
            char[] inOne = one.ToCharArray();
            char[] inTwo = two.ToCharArray();
            int counter = 0;
            for (int i = 0; i < one.Length; i++)
            {
                for (int j = 0; j < two.Length; j++)
                {
                    if (inOne[i] == inTwo[j])
                    {
                        counter++;
                        break;
                    }
                }
            }
            if (counter == inOne.Length)
            {
                return true;
            }
            return false;
        }
    }
}
