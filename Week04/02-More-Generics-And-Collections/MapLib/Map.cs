using DynamicArrayLib;
using System;
using System.Collections.Generic;

namespace MapLib
{
    public class Map<T, U>
    {
        DynamicArray<T> keys;
        DynamicArray<U> values;

        public Map()
        {
            this.keys = new DynamicArray<T>();
            this.values = new DynamicArray<U>();
        }

        public void Clear()
        {
            this.keys.Clear();
            this.values.Clear();
        }

        public void Add(T key, U value)
        {
            if (key.Equals(0))
            {
                throw new ArgumentException("The key must not be Zero!");
            }

            if (ContainsKey(key))
            {
                throw new ArgumentException("The key already exist!");
            }
            this.keys.Add(key);
            this.values.Add(value);
        }

        public bool ContainsKey(T key)
        {
            return this.keys.Contains(key);
        }

        public bool ContainsValue(U value)
        {
            return this.values.Contains(value);
        }

        public void RemoveKey(T key)
        {

            if (ContainsKey(key))
            {
                U value = this[key];
                this.keys.Remove(key);
                this.values.Remove(value);
            }
        }

        public U this[T key]
        {
            get
            {
                if (this.keys.Contains(key))
                {
                    var index = this.keys.IndexOf(key);
                    return this.values[index];
                }
                throw new KeyNotFoundException();
            }
            set
            {
                if (key.Equals(0))
                {
                    throw new Exception("The key musn't be zero!");
                }

                if (this.keys.Contains(key))
                {
                    var index = keys.IndexOf(key);
                    this.values[index] = value;
                }
                else
                {
                    this.keys.Add(key);
                    this.values.Add(value);
                }
            }
        }

    }
}
