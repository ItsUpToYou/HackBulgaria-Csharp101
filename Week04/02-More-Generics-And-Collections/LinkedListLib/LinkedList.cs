using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListLib
{
    public class LinkedList<T>
    {
        private Node head;

        private class Node
        {
            public T Value { get; set; }
            public Node Next { get; set; }
        }

        public void Add(T value)
        {
            var node = new Node();
            node.Value = value;

            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                var current = this.head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = node;
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            var current = this.head;

            while (current != null)
            {
                yield return current.Value;
                current = current.Next;
            }
        }

        public void InsertAfter(T key ,T value)
        {
            var node = new Node();
            node.Value = value;

            var temp = this.head;
            while (!temp.Value.Equals(key))
            {
                if (temp.Next == null)
                {
                    throw new ArgumentOutOfRangeException(string.Format("No Key found with value: {0}", key));
                }
                else
                {
                    temp = temp.Next;
                }

                node.Next = temp.Next;
                temp.Next = node;
            }
        }


        public void InsertBefore(T key, T value)
        {
            var node = new Node();
            node.Value = value;

            var temp = this.head;

           
                if (temp.Value.Equals(key))
                {
                    node.Next = head;
                }
                else
                {
                    while (!temp.Next.Value.Equals(key))
                    {
                        if (temp.Next.Next == null)
                        {
                            throw new ArgumentOutOfRangeException(string.Format("No Key found with value: {0}", key));
                        }
                        temp = temp.Next;
                    }
                    node.Next = temp.Next;
                    temp.Next = node;
                    temp = node;
                }            
        }

        public int Count()
        {
            var temp = this.head;
            var count = 0;
            while (temp != null)
            {
                count++;
                temp = temp.Next;
            }
            return count;
        }

        public void InsertAt(int index, T value)
        {
            var node = new Node();
            node.Value = value;

            var count = 0;
            var temp = this.head;

            if (index > this.Count() || index < 0)
            {
                throw new IndexOutOfRangeException();
            }
            if (index == 0)
            {
                node.Next = this.head;
                this.head = node;
            }
            else
            {
                while (count < index - 1)
                {
                    temp = temp.Next;
                    count++;
                }
                var next = temp.Next;
                node.Next = next;
                temp.Next = node;
            }
        }

        public void Remove(T value)
        {
            var temp = this.head;
            while (!temp.Next.Value.Equals(value))
            {
                temp = temp.Next;
            }
            temp.Next = temp.Next.Next;
        }

        public void RemoveAt(int index)
        {
            var temp = head;
            var count = 0;
            if (index >= this.Count() || index < 0)
            {
                throw new IndexOutOfRangeException();
            }
            if (index == 0)
            {
                this.head = this.head.Next;
            }
            else
            {
                while (count < index - 1)
                {
                    temp = temp.Next;
                    count++;
                }
                temp.Next = temp.Next.Next;
            }
        }

        public void Clear()
        {
            for (int i = this.Count() - 1; i >= 0; i--)
            {
                RemoveAt(i);
            }
        }

        public T this[int index]
        {
            get
            {
                var temp = this.head;
                var count = 0;
                while (count <= index - 1)
                {
                    temp = temp.Next;
                    count++;
                }
                return temp.Value;
            }
            set
            {
                var temp = this.head;
                var count = 0;
                while (count <= index - 1)
                {
                    temp = temp.Next;
                    count++;
                }
                temp.Value = value;
            }
        }

       
    }
}
