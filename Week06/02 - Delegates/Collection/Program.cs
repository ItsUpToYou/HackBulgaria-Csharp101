using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            NotifyCollection test = new NotifyCollection();
            test.CollectionChanged += OnCollectionChange;
            test.Add(23);
            test.Clear();
            test.Add(15);
            test[0] = 13;
        }

        private static void OnCollectionChange(object sender, NotifyArgs e)
        {
            Console.WriteLine(e.Message);
        }
    }
}
