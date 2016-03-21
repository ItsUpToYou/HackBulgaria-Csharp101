using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Aggregates.Delegate;

namespace Aggregates
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> numbers = new List<int>() { 55, 11, 5, 15, 21, 3, 5, 6, 7, 8, 13, 14 };

            AggregationDelegate myDelegate = CalculateAvarage;
            Console.WriteLine("Avarage : {0:F2}", AggregateCollection(numbers, myDelegate));
        }
    }
}
