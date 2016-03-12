using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MapLib;

namespace MapApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Map< int, string> test = new Map<int,string>();
            test.Add(1, "Dominc");
            test.Add(2, "Select");
            test.Add(3, "Create");
            Console.WriteLine(test[1]);
            Console.WriteLine(test[2]);
            Console.WriteLine(test[3]);
            test[5] = "Dian";
            Console.WriteLine(test[5]);
            Console.WriteLine();

            test.RemoveKey(1);

            Console.WriteLine();
            Console.WriteLine(test[2]);
            Console.WriteLine(test[3]);
            Console.WriteLine(test[5]);
            Console.WriteLine();

            Console.WriteLine(test.ContainsKey(2));
            Console.WriteLine(test.ContainsValue("Dian"));
        }
    }
}
