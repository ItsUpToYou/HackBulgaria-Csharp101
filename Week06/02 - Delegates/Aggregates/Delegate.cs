using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aggregates
{
    public static class Delegate
    {
        public delegate T AggregationDelegate<T>(T element, T element2, int pos);

        public static T AggregateCollection<T>(List<T> original, AggregationDelegate<T> aggregation)
        {
            var result = original[0];

            for (int i = 0; i < original.Count; i++)
            {
                result = aggregation(result, original[i], i);
            }
            return result;
        }
    }
}
