using System;
using System.Text;

namespace DecodeURL
{
    class Program
    {

        /*
       Implement the two functions:

       List<int> NumberToList(int n) which takes an integer and returns a list of its digits
       int ListToNumber(string digits) which takes a list of digits and returns the number from those digits
       */

        static void Main(string[] args)
        {
            string word = "kitten%3Apic.jpg";
            char[] wordCharr = word.ToCharArray();
            StringBuilder list = new StringBuilder();
            string addChar = string.Empty;

            for (int i = 0; i < wordCharr.Length; i++)
            {
                if (word[i] != '%')
                {
                    list.Append(wordCharr[i]);
                }
                else
                {
                    for (int j = 0; j < 3; j++)
                    {
                        addChar += wordCharr[i++];
                    }
                    i--;

                    switch (addChar)
                    {
                        case "%20":
                            list.Append(' ');
                            break;

                        case "%3A":
                            list.Append(':');
                            break;

                        case "%3D":
                            list.Append('?');
                            break;

                        case "%2F":
                            list.Append('/');
                            break;

                        default:
                            break;
                    }
                    addChar = string.Empty;
                }
            }
            Console.WriteLine(list);
        }
    }
}
