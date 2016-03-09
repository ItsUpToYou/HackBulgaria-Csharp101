using System;
using System.Collections.Generic;

namespace Animals
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animals> animals = new List<Animals>() { new Dog(1), new Cat(2), new Crocodile(3), new Owl(4), new Shark(5) };
            foreach (var item in animals)
            {
                Console.WriteLine("animal:{0}", item.GetType());
                Console.WriteLine("Age:{0}", item.Birth);
                Console.WriteLine("Sound:{0}", item.Greet());
                Console.WriteLine("Eat: {0}", item.Eat());
                Console.WriteLine("Spped:{0}", item.Move());
                Console.WriteLine();
            }
        }
    }
}
