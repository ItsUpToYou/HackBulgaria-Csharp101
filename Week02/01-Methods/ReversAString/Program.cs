using System;
using System.Collections.Generic;

namespace ReversAString
{
    class Program
    {
        /*
        Write a method which takes a List as an argument and reverses it internally.

        void ReverseList(List<int> list)

        The reversed result should be stored inside the same list instance.
        */

        /// <summary>
        /// Reverse a List<T>
        /// /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        /// <returns></returns>
        static List<T> ReverseList<T>(List<T> list)
        {
            var revList = new List<T>();

            list.Reverse();
            foreach (var element in list)
            {
                revList.Add(element);
            }
            return revList;
        }

        /// <summary>
        /// Print a List<T>
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="ls"></param>
        public static void ShowList<T>(List<T> ls)
        {
            foreach (var item in ReverseList(ls))
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Main method
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            var ls = new List<int>();
            ls.Add(1);
            ls.Add(2);
            ls.Add(3);
            ls.Add(4);
            ls.Add(5);

            ShowList(ls);

        }
    }
}
