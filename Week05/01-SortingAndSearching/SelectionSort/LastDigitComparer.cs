using System.Collections.Generic;

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
                first = int.Parse(y.ToString()[secondLenght - 1].ToString());
            }

            if (first > second)
            {
                return 1;
            }
            else if (first < second)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}
