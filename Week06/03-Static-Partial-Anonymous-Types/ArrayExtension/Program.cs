using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayExtension
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> a = new List<int>() { 1, 2, 3, 4, 5 };
            List<int> b = new List<int>() { 0, 4, 8, 12 };

            var test = ArrayExtension<int>.Intersect(a, b);
            var test2 = ArrayExtension<int>.UnionAll(a, b);
            var test3 = ArrayExtension<int>.Union(a, b);

            foreach (var item in test2)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(DateTime.Now);
        }
    }
}
