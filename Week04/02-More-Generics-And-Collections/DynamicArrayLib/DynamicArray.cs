using System;
using System.Collections;
using System.Linq;

namespace DynamicArrayLib
{
    public class DynamicArray<T> : IEnumerable
    {
        private int size;
        private T[] arr;

        public DynamicArray()
        {
            this.size = 20;
            this.arr = new T[this.size];
        }

        public DynamicArray(int inputSize)
        {
            this.size = inputSize;
            this.arr = new T[size];
        }

        public int Capacity
        {
            get
            {
                return this.size;
            }
        }

        public int Count
        {
            get
            {
                int counter = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] == null || arr[i].Equals(0))
                    {
                        break;
                    }
                    counter++;
                }
                return counter;
            }
        }


        public bool Contains(T value)
        {

            foreach (var val in arr)
            {
                if (val.Equals(value))
                {
                    return true;
                }
            }
            return false;
        }

        public int IndexOf(T value)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Equals(value))
                {
                    return i;
                }
            }
            return -1;
        }

        public void Add(T value)
        {
            if (this.Count >= this.Capacity-1)
            {
                this.size *= 2;
            }

            var arrTemp = new T[this.size];
            for (int i = 0; i < arrTemp.Length; i++)
            {
                arrTemp[i] = arr[i];
            }
            arrTemp[this.Count] = value;
            this.arr = arrTemp;
        }

        public void InsertAt(int index, T value)
        {
            if (index > this.Count)
            {
                throw new IndexOutOfRangeException();
            }
            var arrTemp = this.arr.ToList();
            arrTemp.Insert(index, value);
            this.arr = arrTemp.ToArray();
        }

        public void Remove(T value)
        {
            var arrTemp = arr.ToList();
            arrTemp.Remove(value);
            arr = arrTemp.ToArray();

            if (this.Count < this.Capacity / 3)
            {
                this.size /= 2;
                var arrCur = new T[this.size];
                for (int i = 0; i < this.Count; i++)
                {
                    arrCur[i] = arr[i];
                }
                this.arr = arrCur;
            }
        }

        public void RemoveAt(int index)
        {
            var arrTemp = arr.ToList();
            if (index < arrTemp.Count)
            {
                arrTemp.RemoveAt(index);
                this.arr = arrTemp.ToArray();
            }
            else
            {
                Console.WriteLine("The input index is out of the list indexes.");
            }
          
            if (this.Count < this.Capacity / 3)
            {
                this.size /= 2;
                var arrCur = new T[size];
                for (int i = 0; i < this.Count; i++)
                {
                    arrCur[i] = arr[i];
                }
                this.arr = arrCur;
            }

        }

        public void Clear()
        {
            var arrTemp = this.arr.ToList();
            arrTemp.Clear();
            this.arr = arrTemp.ToArray();
        }

        public T this[int index]
        {
            get
            {
                if (index > this.Count)
                {
                    throw new IndexOutOfRangeException();
                }
                return this.arr[index];
            }

            set
            {
                if (index > this.Count)
                {
                    throw new IndexOutOfRangeException("out");
                }
                this.arr[index] = value;
            }
        }

        public T[] Array()
        {
            var arrTemp = new T[this.Count];

            for (int i = 0; i < this.Count; i++)
            {
                arrTemp[i] = this.arr[i];
            }
            return arrTemp;
        }

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < this.Count; i++)
            {
                yield return this.arr[i];
            }
        }
    }
}
