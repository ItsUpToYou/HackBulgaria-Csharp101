using System;
using LinkedListLib;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<string> list = new LinkedList<string>();
            list.Add("Antonio");
            list.Add("Ivanio");
            list.Add("Bonbonio");
            list.Add("Bonbonio2");
            list.InsertAfter("Ivanio", "Nora");
            list.InsertBefore("Nora", "Lory");
            list.InsertAt(3, "Thom");
            list.Remove("Ivanio");
            list.RemoveAt(2);
            foreach (string value in list)
            {
                Console.WriteLine(value);
            }
            Console.WriteLine();

            Console.WriteLine(list[4]);
            list[1] = "change";
            Console.WriteLine(list[1]);
            Console.WriteLine(list.Count());

            Console.WriteLine();
            foreach (string value in list)
            {
                Console.WriteLine(value);
            }

        }
    }
}
