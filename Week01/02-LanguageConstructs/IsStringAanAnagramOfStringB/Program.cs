using System;

namespace IsStringAanAnagramOfStringB
{
    class Program
    {

        /*
        bool Anagram(string A, string B) See http://en.wikipedia.org/wiki/Anagram

        No HashMaps, hashSets, or such stuff allowed : )
        */


        static bool AreAnagram(string s1, string s2)
        {
            foreach (char c in s1)
            {
                int ix = -1;
                for (var i = 0; i < s2.Length; i++)
                {
                    if (s2[i] == c)
                    {
                        ix = i;
                        break;
                    }
                }

                if (ix == -1)
                    return false;
            }
            return true;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(AreAnagram("aba", "aba"));
        }
    }
}
