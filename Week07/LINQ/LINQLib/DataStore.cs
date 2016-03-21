using System.Collections.Generic;

namespace LINQLib
{
    public class DataStore
    {
         List<Product> products { get; set; }
         List<Order> orders { get; set; }
         List<Category> categories { get; set; }

        public DataStore()
        {
            this.products = new List<Product>();
            this.orders = new List<Order>();
            this.categories = new List<Category>();
        }

        public void AddProduct(Product prod)
        {
            products.Add(prod);
        }

        public void AddOrder(Order order)
        {
            orders.Add(order);
        }

        public void AddCategory(Category categor)
        {
            categories.Add(categor);
        }

        public List<Product> GetProducts()
        {
            return this.products;
        }

        public List<Order> GetOrders()
        {
            return orders;
        }

        public List<Category> GetCategories()
        {
            return categories;
        }

    }
}
