using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseEachWordInASentence
{
    class Program
    {
        /*
        Implement a function which takes a string and returns a string which has the same words but each word is in a reverse order.

        string ReverseEveryWord(string sentence)
        */

        static void ReverseStr(List<char> list, StringBuilder str)
        {
            for (int j = list.Count - 1; j >= 0; j--)
            {
                str.Append(list[j]);
            }
        }
        static void Main(string[] args)
        {
            string words = "54321 dcba bbaa";

            StringBuilder str = new StringBuilder();
            List<char> charList = new List<char>();

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i] == ' ')
                {
                    ReverseStr(charList, str);
                    str.Append(' ');
                    charList = new List<char>();
                }
                else if (i == words.Length - 1)
                {
                    charList.Add(words[i]);
                    ReverseStr(charList, str);
                }
                else
                    charList.Add(words[i]);
            }
            Console.WriteLine(str.ToString());
        }
    }
}
