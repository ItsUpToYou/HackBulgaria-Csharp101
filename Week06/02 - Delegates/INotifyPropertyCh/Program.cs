using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INotifyPropertyCh
{
    class Program
    {
        static void Main(string[] args)
        {
            Items item1 = new Items(1, "testing", 34);
            item1.PropertyChanged += Item1_PropertyChanged;
            item1.ProductId = 23;
            item1.ProductPrice = 213;
            item1.ProductName = "test";
        }
        private static void Item1_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            Console.WriteLine("Item has changed");
        }
    }
}
