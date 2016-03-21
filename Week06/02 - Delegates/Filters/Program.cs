using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filters
{
    class Program
    {   
        static void Main(string[] args)
        {
            Delegate.FilterDelegate<int> myDelegate = Delegate.IsInRange;

            List<int> numbers = new List<int>() { 1, 11, 5, 15, 21, 3, 5, 6, 7, 8, 13, 14 };

            // Version with Func:

            // Func<int, bool> myFunc = Filter;

            numbers = Delegate.FilterCollection(numbers, myDelegate);

            var result = string.Join(", ", numbers);
            Console.WriteLine(result);
        }
    }
}
