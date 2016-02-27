using System;
using System.Collections.Generic;

namespace Transversal
{
    class Program
    {
        /*
        Lets have a set of sets:
        A = { {1, 2, 3} , {4, 5, 6}, {7, 8, 9} }
        A transversal T for A is a set that contains at least one element from each set of A.
        For example: T = {1, 4, 7}
        Implement a function bool IsTransversal(List<int> transversal, List<List<int>> family), which checks if given set is a valid transerval for another family of sets (set of sets).
        Examples:
        >>> IsTransversal({4, 5, 6}, {{5, 7, 9}, {1, 4, 3}, {2, 6}}))
        true
        >>> IsTransversal({1, 2}, {{1, 5}, {2, 3}, {4, 7}})
        false
        >>> IsTransversal({2, 3, 4}, {{1, 7}, {2, 3, 5}, {4, 8}})
        false
        */

        static void Main(string[] args)
        {
            List<int> transversal = new List<int>() { 11, 23, 13 };
            List<List<int>> family = new List<List<int>>(){
                new List<int>(){ 5,7,23},
                new List<int>() { 1, 11, 3},
                new List<int> { 13, 6 }
            };
            Console.WriteLine(IsTransversal(transversal, family));
        }

        public static bool IsTransversal(List<int> transversal, List<List<int>> family)
        {
            bool IsATransversal = true;

            foreach (var list in family)
            {
                foreach (var digit in transversal)
                {
                    if (list.Contains(digit))
                    {
                        IsATransversal = true;
                        break;
                    }
                    IsATransversal = false;
                }
            }
            return IsATransversal;
        }
    }
}
