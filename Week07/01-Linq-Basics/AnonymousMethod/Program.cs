using System;
using System.ComponentModel;

namespace AnonymousMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            AverageAggregator test = new AverageAggregator();
            test.PropertyChanged += Test_PropertyChanged;
            test.PropertyChanged += delegate (object s, PropertyChangedEventArgs e)
            
            //anonymous method
            {
                AverageAggregator agg = (AverageAggregator)s;
                Console.WriteLine("{1} Anonymous method: {0}", agg.Average);
            };

            test.PropertyChanged += ((o, s) => Console.WriteLine("Lambda Expressions"));

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
