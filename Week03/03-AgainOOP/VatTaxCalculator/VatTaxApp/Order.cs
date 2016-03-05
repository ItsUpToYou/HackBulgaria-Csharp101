using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VatTaxApp
{
    public class Order
    {
        private Dictionary<int, int> orderedProduct = new Dictionary<int, int>();

        public Dictionary<int, int> OrderedProduct
        {
            get { return orderedProduct; }
        }

        public Order(Dictionary<int, int> orderedProduct)
        {
            this.orderedProduct = new Dictionary<int, int>();
            foreach (var item in orderedProduct)
            {
                this.orderedProduct.Add(item.Key, item.Value);
            }
        }           
    }
}
