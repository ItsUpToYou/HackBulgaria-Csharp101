using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionSort
{
    public class LastDigitComparer : IComparer<int>
    {
        public int Compare(int x, int y)
        {
            int first = x;
            int second = y;

            int firstLenght = x.ToString().Length;
            int secondLenght = y.ToString().Length;

            if (firstLenght > 1)
            {
                first = int.Parse(x.ToString()[firstLenght - 1].ToString());
            }
            if (secondLenght > 1)
            {
                first = int.Parse(x.ToString()[second - 1].ToString());

            }
        }
    }
}
