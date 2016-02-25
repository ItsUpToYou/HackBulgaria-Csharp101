using System;
using System.Collections.Generic;

namespace CharHistogram
{
    class Program
    {
        /*
        Implement a funcion, called CharHistogram(string), which takes a string and returns a dictionary, where each key is a character from string and its value is the number of occurrences of that char in string.

        CharHistogram("Python!") =
        { 'P': 1, 'y': 1, 't': 1, 'h': 1, 'o': 1, 'n': 1, '!': 1 }
        CharHistogram("AAAAaaa!!!") 
        'A': 4, 'a': 3, '!": 3 }
        */

        static void Main(string[] args)
        {
            string inputWord = Console.ReadLine();
            CharHistogram(inputWord);
        }

        public static Dictionary<char, int> CharHistogram(string input)
        {
            Dictionary<char, int> charHistogram = new Dictionary<char, int>();
            foreach (var item in input)
            {
                if (charHistogram.ContainsKey(item))
                {
                    charHistogram[item] += 1;
                }
                else
                {
                    charHistogram.Add(item, 1);
                }
            }

            foreach (var item in charHistogram)
            {
                Console.WriteLine("Letter {0} : {1} occurences", item.Key, item.Value);
            }
            return charHistogram;
        }
    }
}
