using System;
using System.Collections.Generic;

namespace NumberListandListNumber
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
            int number = 153; //int.Parse(Console.ReadLine());
            List<int> list = new List<int>();

            while (number != 0)
            {
                list.Add(number % 10);
                number /= 10;
            }
            foreach (var item in list)
            {
                Console.Write("{0},", item);
            }

            list.Reverse();
            Console.WriteLine();
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write("{0},", list[i]);
            }

            Console.WriteLine();
            Console.WriteLine(ListToNumber(list));
        }

        static int ListToNumber(List<int> list)
        {
            int result = 0;

            foreach (var numb in list)
            {
                result *= 10;
                result += numb;
            }

            return result;
        }
    }
}

