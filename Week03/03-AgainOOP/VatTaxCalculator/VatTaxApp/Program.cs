using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VatTaxLib;

namespace VatTaxApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<CountryVatTax> countries = new List<CountryVatTax>()
            {
                new CountryVatTax("Bulgaria", 20, false),
                new CountryVatTax("Greece", 19, false),
                new CountryVatTax("Slovenia", 20, false),
                new CountryVatTax("Indonesia", 0.24m, true),
                new CountryVatTax("Netherland", 0.27m, false)
                
            };

            VatTaxCalculator calc = new VatTaxCalculator(countries);

            Product[] products = new Product[]
            {
                new Product("Sugar"     , 1, 31, 1, 4.2M, calc),
                new Product("olives"    , 2, 22, 2, 5.3M, calc),
                new Product("Coca-cola" , 3, 11, 3, 6, calc),
                new Product("Flour"     , 4, 15, 4, 7, calc),
                new Product("meat"      , 5, 13, 5, 7.5M, calc)
            };

            ShopInventory shop = new ShopInventory(products.ToList());

            Dictionary<int, int> items1 = new Dictionary<int, int>();
            items1.Add(1, 2);
            items1.Add(2, 20);
            items1.Add(3, 2);
            Order order1 = new Order(items1);

            Dictionary<int, int> items2 = new Dictionary<int, int>();
            items2.Add(3, 8);
            items2.Add(4, 1);
            items2.Add(5, 3);
            Order order2 = new Order(items2);

            Dictionary<int, int> items3 = new Dictionary<int, int>();
            items3.Add(2, 13);
            items3.Add(4, 3);
            items3.Add(5, 2);
            Order order3 = new Order(items3);

            try
            {
                Console.WriteLine("Audit: {0}", shop.Audit());
                Console.WriteLine("Order 1 value: {0}", shop.RequestOrder(order1));
                Console.WriteLine("Audit: {0}", shop.Audit());
                Console.WriteLine("Order 2 value: {0}", shop.RequestOrder(order2));
                Console.WriteLine("Audit: {0}", shop.Audit());
                Console.WriteLine("Order 3 value: {0}", shop.RequestOrder(order3));
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: {0}", ex.Message);
            }

            Console.WriteLine("Audit: {0}", shop.Audit());
        }
    }
}
