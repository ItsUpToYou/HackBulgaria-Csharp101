using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackCompanyLib
{
    public class Product
    {
        public int ProdId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string CategoryId { get; set; }

        public Product(int id, string name, decimal price, string categId )
        {
            this.ProdId = id;
            this.Name = name;
            this.Price = price;
            this.CategoryId = categId;
        }

    }
}
