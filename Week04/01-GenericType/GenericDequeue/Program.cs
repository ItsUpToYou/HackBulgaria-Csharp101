using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDequeue
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        public class Dequeue<T>
        {
            int MAX_SIZE = 100;
            public T[] arr;
            int numberOfPush = 0;

            public Dequeue()
            {
                this.arr = new T[MAX_SIZE];
            }

            public T PeekFromFront()
            {
                return arr[0];
            }

            public T PeekFromEnd()
            {
                return arr[numberOfPush - 1];
            }

            public void AddToFront(T item)
            {
                T[] temp = new T[MAX_SIZE];
                numberOfPush++;
                if (numberOfPush > MAX_SIZE)
                {
                    Resize();
                }

                for (int i = 0; i < arr.Length; i++)
                {
                    if (i == 0)
                    {
                        temp[i] = item;
                    }
                    else
                    {
                        temp[i] = arr[i - 1];
                    }
                }
                arr = temp;
            }

            public void AddToEnd(T item)
            {
                T[] temp = new T[MAX_SIZE];
                numberOfPush++;
                if (numberOfPush > MAX_SIZE)
                {
                    Resize();
                }

                for (int i = 0; i < arr.Length; i++)
                {
                    if (i == numberOfPush)
                    {
                        temp[numberOfPush] = item;
                    }
                    else
                    {
                        temp[i] = arr[i];
                    }
                }
                arr = temp;

            }

            public T RemoveFromFront()
            {
                T result = PeekFromFront();
                numberOfPush--;
                T[] temp = new T[MAX_SIZE];
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    temp[i] = arr[i + 1];
                }
                arr = temp;
                return result;
            }

            public T RemoveFromEnd()
            {
                T result = PeekFromEnd();
                numberOfPush--;
                T[] temp = new T[MAX_SIZE];
                arr[numberOfPush - 1] = default(T);
                numberOfPush--;
                return result;
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
        }
    }
}
