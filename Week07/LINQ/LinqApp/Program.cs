namespace LinqApp
{
    using LINQLib;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;


    class Program
    {
        static void Main(string[] args)
        {
            DataStore data = new DataStore();
            data.AddCategory(new Category(300, "Shoes"));
            data.AddCategory(new Category(301, "Pants"));
            data.AddCategory(new Category(302, "TShirt"));
            data.AddCategory(new Category(400, "Toys"));
            data.AddCategory(new Category(420, "Diamond"));
            data.AddCategory(new Category(430, "Gum"));
            data.AddCategory(new Category(500, "Books"));
            data.AddCategory(new Category(600, "Nuts"));
            data.AddCategory(new Category(700, "Vegetables"));

            data.AddProduct(new Product("Nike", 1, 300));
            data.AddProduct(new Product("Reebok", 2, 300));
            data.AddProduct(new Product("Long", 12, 301));
            data.AddProduct(new Product("Jeans", 22, 301));
            data.AddProduct(new Product("White", 32, 302));
            data.AddProduct(new Product("Green", 42, 302));
            data.AddProduct(new Product("Truck", 52, 400));
            data.AddProduct(new Product("Car", 62, 400));
            data.AddProduct(new Product("Queen", 64, 420));
            data.AddProduct(new Product("24k", 66, 420));
            data.AddProduct(new Product("Turbo", 72, 430));
            data.AddProduct(new Product("Orbit", 82, 430));
            data.AddProduct(new Product("Shadow", 96, 500));
            data.AddProduct(new Product("Sun", 100, 500));
            data.AddProduct(new Product("almons", 102, 600));
            data.AddProduct(new Product("pistachios", 123, 600));
            data.AddProduct(new Product("Tomatto", 125, 700));
            data.AddProduct(new Product("aubergine", 130, 700));

            data.AddOrder(new Order(
                1, new List<int>() { 1, 12, 22, 53, 72, 123 }, DateTime.Now.AddDays(1).AddHours(2), "Order1"
                ));
            data.AddOrder(new Order(
                2, new List<int>() { 82, 12, 125, 130, 72, 96 }, DateTime.Now.AddDays(2).AddHours(1), "Order2"
                 ));
            data.AddOrder(new Order(
                3, new List<int>() { 32, 42, 52, 63 }, DateTime.Now.AddDays(5).AddHours(-3), "Order3"
                ));
            data.AddOrder(new Order(
                4, new List<int>() { 2, 52, 72, 123 }, DateTime.Now.AddDays(6).AddHours(4), "Order4"
                ));

            //All products with ids between 15 and 30
            var prod15_30 = from product in data.GetProducts()
                            where product.ProductId >= 15 && product.ProductId <= 30
                            select product;

            //All categories with ids between 105 and 125
            var categor105_125 = from category in data.GetCategories()
                                 where category.CategoryId >= 105 && category.CategoryId <= 125
                                 select category;

            //First 15 orders sorted by order name
            var sorted = from order in data.GetOrders()
                         orderby order.Name
                         select order;

            //First 3 orders which contains productId 5, sorted by order date
            var sortedProd = from order in data.GetOrders()
                             where order.Products.Contains(12)
                             orderby order.OrderDate
                             select order;

            foreach (var item in sortedProd)
            {
                Console.WriteLine($"Order ID:{item.OrderId}, Order Name:{item.Name}, Products:{string.Join(", ", item.Products)}, Date:{item.OrderDate} ");
            }


            //All product with the name of the category, which they belong to, order by CategoryName
            var prodCateg = from product in data.GetProducts()
                         join category in data.GetCategories()
                         on product.CategoryId equals category.CategoryId
                         select new { ProductName = product.Name, ProductCategory = category.CategoryName };

            Console.WriteLine();
            foreach (var product in prodCateg)
            {
                Console.WriteLine($"ProductName: {product.ProductName}, ProductCategory:{product.ProductCategory}");
            }

            //All categories together with their products
            Console.WriteLine();

            var categProd = from order in data.GetOrders()
                            let prodWithCateg = (from prodId in order.Products
                                                 join product in data.GetProducts()
                                                       on prodId equals product.ProductId
                                                 join category in data.GetCategories()
                                                       on product.CategoryId equals category.CategoryId
                                                 select new { ProductName = product.Name, CategoryName = category.CategoryName })
                            orderby order.OrderDate
                            select new
                            {
                                OrderId = order.OrderId,
                                OrderName = order.Name,
                                ProductsWithCategory = prodWithCateg,
                                OrderDate = order.OrderDate
                            };
            Console.WriteLine();
            foreach (var order in categProd)
            {
                Console.WriteLine("OrderId: {0}", order.OrderId);
                Console.WriteLine("OrderName: {0}", order.OrderName);
                Console.WriteLine("Ordered Products:");
                Console.WriteLine("=======================");

                foreach (var product in order.ProductsWithCategory)
                {
                    Console.WriteLine("Product: {0} - {1}", product.ProductName, product.CategoryName);
                }
                Console.WriteLine("Order Date: {0}", order.OrderDate);
                Console.WriteLine();            }
        }
    }
}
