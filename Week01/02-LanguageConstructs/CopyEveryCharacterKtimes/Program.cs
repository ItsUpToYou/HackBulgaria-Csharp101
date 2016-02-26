using System;

namespace CopyEveryCharacterKtimes
{
    class Program
    {

        /*
        string CopyEveryChar(string input, int k)

        Example: CopyEveryChar("tldr", 3) => "tttllldddrrr"
        */

        static string CopyEveryChar(string input, int k)
        {
            string output = string.Empty;
            for (int i = 0; i < input.Length; i++)
            {
                for (int j = 0; j < k; j++)
                {
                    output += input[i];
                }
            }
            return output;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(CopyEveryChar("brav", 4));
        }
    }
}
