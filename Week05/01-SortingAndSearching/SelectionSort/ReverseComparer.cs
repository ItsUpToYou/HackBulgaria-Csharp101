using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionSort
{
    public class ReverseComparer<T> : IComparer<T>
    {
        private IComparer<T> comparer;

        internal ReverseComparer(IComparer<T> compar)
        {
            this.comparer = compar;
        }

        public int Compare(T x, T y)
        {
            return -comparer.Compare(x, y);
        }
    }
}
