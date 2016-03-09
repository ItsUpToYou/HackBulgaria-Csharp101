using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageAggregator
{
    class Program
    {
        static void Main(string[] args)
        {
            AverageAggregator test = new AverageAggregator();
            test.PropertyChanged += Test_PropertyChanged;
            test.AddNumber(20);
            test.AddNumber(30);
            test.AddNumber(48);

            Console.WriteLine(test.Average);
        }

        private static void Test_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            Console.WriteLine("Average property changed");
        }
    }
}
