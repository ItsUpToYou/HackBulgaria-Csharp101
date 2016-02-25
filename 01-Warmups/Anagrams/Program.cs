using System;
using System.Collections.Generic;
using System.Linq;

namespace Anagrams
{
    class Program
    {
        /*In the given language, implement the factorial function n!.

        Implement it using a simple loop
        Implement it using recursion
        */
        static void Main(string[] args)
        {
            string fStr = Console.ReadLine();
            string sStr = Console.ReadLine();
            Console.WriteLine("String \"{0}\" and string \"{1}\" are anagrams : {2}  ", fStr, sStr, IsAnagram(fStr, sStr));
        }

        public static bool IsAnagram(string a, string b)
        {
            Dictionary<char, int> dictA = new Dictionary<char, int>();
            foreach (var letter in a)
            {
                if (dictA.ContainsKey(letter))
                {
                    dictA[letter] += 1;
                }
                else
                {
                    dictA.Add(letter, 1);
                }
            }

            Dictionary<char, int> dictB = new Dictionary<char, int>();
            foreach (var letter in b)
            {
                if (dictB.ContainsKey(letter))
                {
                    dictB[letter] += 1;
                }
                else
                {
                    dictB.Add(letter, 1);
                }
            }

            bool isEqual = dictA.OrderBy(r => r.Key).SequenceEqual(dictB.OrderBy(r => r.Key));
            return isEqual;
        }
    }
}
