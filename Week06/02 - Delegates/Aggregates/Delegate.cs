using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aggregates
{
    public static class Delegate
    {
        public delegate decimal AggregationDelegate(List<int> num);

        public static decimal AggregateCollection(List<int> original, AggregationDelegate aggregation)
        {
            
            return aggregation(original);
        }

        public static void Min(List<int> numbers)
        {
            int minNumber = numbers.ElementAt(0);
            for (int i = 1; i < numbers.Count; i++)
            {
                if (numbers.ElementAt(i) < minNumber)
                {
                    minNumber = numbers.ElementAt(i);
                }
            }
            Console.WriteLine("Min Number: {0}", minNumber);
        }

        public static void Max(List<int> numbers)
        {
            int maxNumber = numbers.ElementAt(0);
            for (int i = 1; i < numbers.Count; i++)
            {
                if (numbers.ElementAt(i) > maxNumber)
                {
                    maxNumber = numbers.ElementAt(i);
                }
            }
            Console.WriteLine("Max Number: {0}",maxNumber);
        }

        public static void Sum(List<int> numbers)
        {
            var sum = 0;
            foreach (var number in numbers)
            {
                sum += number;
            }
            Console.WriteLine("Sum Of Numbers: {0}", sum);
        }

        public static void Average(List<int> numbers)
        {
            double sum = 0;
            foreach (var number in numbers)
            {
                sum += number;
            }
            Console.WriteLine("Numbers Average: {0:F2}", sum / numbers.Count);
        }

        public static decimal CalculateAvarage(List<int> numbers)
        {
            decimal sum = 0;
            foreach (var number in numbers)
            {
                sum += number;
            }
            return sum / numbers.Count;
        }
    }
}
