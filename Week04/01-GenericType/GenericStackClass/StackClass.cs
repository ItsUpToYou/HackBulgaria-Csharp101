using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericStackClass
{
    public class StackClass<T>
    {
        int MAX_SIZE = 100;
        public T[] arr;
        int numberOfPush = 0;

        public StackClass()
        {
            this.arr = new T[MAX_SIZE];
        }

        public void Resize()
        {
            MAX_SIZE = MAX_SIZE * 2;
            T[] temp = new T[MAX_SIZE];
            for (int i = 0; i < arr.Length; i++)
            {
                temp[i] = arr[i];
            }
            arr = temp;
        }

        public void Push(T item)
        {
            numberOfPush++;
            if (numberOfPush > MAX_SIZE)
            {
                Resize();
            }

            arr[numberOfPush - 1] = item;
        }

        public T Peek()
        {
            return arr[numberOfPush - 1];
        }

        public void Pop()
        {
            Peek();
            arr[numberOfPush - 1] = default(T);
            numberOfPush--;
        }

        public void Clear()
        {
            arr = new T[MAX_SIZE];
        }

        public bool Contains(T item)
        {
            for (int i = 0; i < numberOfPush - 1; i++)
            {
                if (arr[i].Equals(item))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
