using System;

namespace Pair
{
    class Program
    {
        static void Main(string[] args)
        {
            Pairs p = new Pairs(12, 33);
            Pairs p1 = new Pairs(54, 54);
            Pairs p2 = new Pairs(12, 33);

            Console.WriteLine(p.ToString());
            Console.WriteLine(p.Equals(p1));
            Console.WriteLine(p.Equals(p2));

        }
    }
}
