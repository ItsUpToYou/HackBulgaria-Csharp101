namespace GenericStackClass
{

using System;

    class Program
    {
        static void Main(string[] args)
        {
            StackClass<int> test = new StackClass<int>();
            test.Push(2);
            test.Push(23);
            test.Push(31);
            test.Push(13);
            test.Push(7);
            Console.WriteLine(test.Peek());
            test.Pop();
            Console.WriteLine(test.Peek());
            // test.Clear();
            //Console.WriteLine(test.Peek());
            Console.WriteLine(test.Contains(11));
            Console.WriteLine(test.Contains(23));
        }
    }
}
