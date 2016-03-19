using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Incrementable
{
    class Program
    {
        static void Main(string[] args)
        {
            TestClass test = new TestClass();
            test.PropInt1 = 1;
            test.PropInt2 = 2;
            //test.MyProperty3 = "xxxxxxxxx";
            ExtentionMethod.IncrementMethod(test);
            Console.WriteLine(test.PropInt1); //2
            Console.WriteLine(test.PropInt2); //3
            //Console.WriteLine(test.MyProperty3);   
        }
    }
}
