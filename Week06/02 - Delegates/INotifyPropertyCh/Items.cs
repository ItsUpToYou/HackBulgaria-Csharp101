using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INotifyPropertyCh
{
    public class Items : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int ProductPrice { get; set; }

        public Items()
        {

        }
        public Items(int prod, string name, int price)
        {
            this.ProductId = prod;
            this.ProductName = name;
            this.ProductPrice = price;
        }

    }
}
