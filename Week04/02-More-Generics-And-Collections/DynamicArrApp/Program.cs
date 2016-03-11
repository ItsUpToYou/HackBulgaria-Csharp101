using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DynamicArrayLib;

namespace DynamicArrApp
{
    class Program
    {
        static void Main(string[] args)
        {
            DynamicArray<string> arr = new DynamicArray<string>();
            arr.Add("My test0");
            arr.Add("My test1");
            arr.Add("My test2");
            arr.Add("My test3");

            Console.WriteLine(arr.Count);
            Console.WriteLine(arr.Capacity);
            Console.WriteLine(arr.Contains("My test2"));
            Console.WriteLine(arr.IndexOf("My test2"));
            arr.InsertAt(2,"My test insert");

            arr.Remove("My test2");
            
            Console.WriteLine();
            arr.RemoveAt(3);
            //arr.Clear();
            arr[3] = "add with index";
            arr.InsertAt(0, "insert test");

            for (int i = 0; i < arr.Count; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
