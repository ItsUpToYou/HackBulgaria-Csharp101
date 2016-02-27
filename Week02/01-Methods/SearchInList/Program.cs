using System;
using System.Collections.Generic;

namespace SearchInList
{
    class Program
    {
        /*
        Write a method which takes a list of strings as an argument and a string to search for. 
        If any of the strings in the list contains the searched string (as a substring), 
        the method should return true. Otherwise it should return false. 
        The first index of a string which contains the searched one should be stored 
        in the out parameter.

        bool TryFindSubstring(List<string> list, string searched, out foundIndex)
        */

        static bool TryFindSubstring(List<string> list, string searched, out int foundIndex)
        {
            foundIndex = 0;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Contains(searched))
                {
                    foundIndex = i;
                    return true;
                }
            }
            return false;
        }
        static void Main(string[] args)
        {
            int num = 0;
            var ls = new List<string>();
            ls.Add("aac");
            ls.Add("abc");
            ls.Add("acc");

            TryFindSubstring(ls, "acc", out num);
            Console.WriteLine(num);
        }
    }
}
