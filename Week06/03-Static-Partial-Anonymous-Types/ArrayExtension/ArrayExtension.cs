using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayExtension
{
    public static class ArrayExtension<T>
    {
        private static readonly char ReplacingValue;

        static ArrayExtension()
        {
            ReplacingValue = Configuration.GetReplaceValue();
        }

        public static List<T> Intersect(List<T> firstList, List<T> secondList)
        {
            List<T> intersection = new List<T>();

            for (int i = 0; i < firstList.Count; i++)
            {
                if (secondList.Contains(firstList[i]))
                {
                    intersection.Add(firstList[i]);
                }
            }
            return intersection;
        }

        public static List<T> UnionAll(List<T> firstList, List<T> secondList)
        {
            List<T> union = new List<T>();

            for (int i = 0; i < firstList.Count; i++)
            {
                union.Add(firstList[i]);
            }

            for (int i = 0; i < secondList.Count; i++)
            {
                union.Add(secondList[i]);
            }
            return union;
        }

        public static List<T> Union(List<T> firstList, List<T> secondList)
        {
            List<T> union = new List<T>();

            for (int i = 0; i < firstList.Count; i++)
            {
                union.Add(firstList[i]);
            }

            for (int i = 0; i < secondList.Count; i++)
            {
                if (!union.Contains(secondList[i]))
                {
                    union.Add(secondList[i]);
                }
            }
            return union;
        }

        public static string Join(List<string> list)
        {
            List<string> filteredList = new List<string>();


            //for (int i = 0; i < list.Count; i++)
            //{
            //    for (int j = 0; j < list[i].Length; j++)
            //    {
            //        if (ReplacingValue == list[i][j])
            //        {
            //            filteredList.Add(list[i]);
            //        }
            //    }
            //}

            return string.Join(ReplacingValue.ToString(), list);
        }

    }
}
