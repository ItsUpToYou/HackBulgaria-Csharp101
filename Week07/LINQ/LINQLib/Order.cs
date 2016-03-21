using System;
using System.Collections.Generic;

namespace LINQLib
{
    public class Order
    {
        public int OrderId { get; set; }
        public List<int> Products { get; set; }
        public DateTime OrderDate { get; set; }
        public string Name { get; set; }

        public Order(int orderId, List<int> prod, DateTime orderDate, string name)
        {
            this.OrderId = orderId;
            this.Products = prod;
            this.OrderDate = OrderDate;
            this.Name = name;
        }
    }
}
