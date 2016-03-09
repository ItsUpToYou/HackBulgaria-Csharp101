using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filters
{
    public class Delegate
    {
        public delegate bool FilterDelegate<T>(T element);

        public static List<T> FilterCollection<T>(List<T> original, FilterDelegate<T> filter)
        {
            var list = new List<T>();

            foreach (var item in original)
            {
                if (filter(item))
                {
                    list.Add(item);
                }
            }
            return list;
        }


    }
}
